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

        public static void RegisterUser(string login, string password, int easyClicks = 0, int mediumClicks = 0, int hardClicks = 0)
        {
            try
            {
                string UsersFilePath = Path.Combine(Application.StartupPath, UsersFileName);

                using (StreamWriter writer = new StreamWriter(UsersFilePath, true))
                {
                    writer.WriteLine($"{login},{password},{easyClicks},{mediumClicks},{hardClicks}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при создании пользователя: " + ex.Message);
            }
        }

        public static void UpdateUserClicks(string login, int newClicks, string level)
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
                        int currentBestClicks = int.Parse(parts[index]);
                        if (newClicks > currentBestClicks)
                        {
                            parts[index] = newClicks.ToString();
                            lines[i] = string.Join(",", parts);
                            break;
                        }
                    }
                }
                File.WriteAllLines(UsersFilePath, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при обновлении количества нажатий пользователя: " + ex.Message);
            }
        }

        public static List<(string Login, int Clicks)> GetTopPlayers(string level)
        {
            try
            {
                string UsersFilePath = Path.Combine(Application.StartupPath, UsersFileName);

                string[] lines = File.ReadAllLines(UsersFilePath);
                int levelIndex = GetLevelIndex(level);
                return lines.Select(line =>
                {
                    string[] parts = line.Split(',');
                    return (Login: parts[0], Clicks: int.Parse(parts[levelIndex]));
                })
                .Where(player => player.Clicks > 0)
                .OrderByDescending(player => player.Clicks)
                .Take(3)
                .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении топ игроков: " + ex.Message);
                return new List<(string Login, int Clicks)>();
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
