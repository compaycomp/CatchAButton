using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Cursach
{
    public static class UserManager
    {
        private const string UsersFileName = "users.txt";
        

        public static void RegisterUser(string login, string password, int easyTime = 0, int mediumTime = 0, int hardTime = 0)
        {
            try
            {
                string UsersFilePath = Path.Combine(Application.StartupPath, UsersFileName);

                using (StreamWriter writer = new StreamWriter(UsersFilePath, true))
                {
                    writer.WriteLine($"{login},{password},{easyTime},{mediumTime},{hardTime}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при создании пользователя: " + ex.Message);
            }
        }

        public static void UpdateUserTime(string login, int newTime, string level)
        {
            try
            {
                string UsersFilePath = Path.Combine(Application.StartupPath, UsersFileName);

                string[] lines = File.ReadAllLines(UsersFilePath);
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(',');
                    if (parts[0] == login)
                    {
                        int index = GetLevelIndex(level);
                        int currentBestTime = int.Parse(parts[index]);
                        if (newTime < currentBestTime || currentBestTime == 0)
                        {
                            parts[index] = newTime.ToString();
                            lines[i] = string.Join(",", parts);
                            break;
                        }
                    }
                }
                File.WriteAllLines(UsersFilePath, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении времени пользователя: " + ex.Message);
            }
        }

        public static List<(string Login, int Time)> GetTopPlayers(string level)
        {
            try
            {
                string UsersFilePath = Path.Combine(Application.StartupPath, UsersFileName);

                string[] lines = File.ReadAllLines(UsersFilePath);
                int levelIndex = GetLevelIndex(level);
                return lines.Select(line =>
                {
                    string[] parts = line.Split(',');
                    return (Login: parts[0], Time: int.Parse(parts[levelIndex]));
                })
                .Where(player => player.Time > 0)
                .OrderBy(player => player.Time)
                .Take(3)
                .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении топ игроков: " + ex.Message);
                return new List<(string Login, int Time)>();
            }
        }

        private static int GetLevelIndex(string level)
        {
            if (level == "easy") return 2;
            if (level == "medium") return 3;
            if (level == "hard") return 4;
            throw new ArgumentException("Invalid level");
        }
    }
}
