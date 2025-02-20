using System;
using System.IO;
using LiteDB;

namespace LiteDBPresetDeleter
{
    class Program
    {
        static void Main(string[] args)
        {
            string swarmUIInstallDir = "";
            string dbPath = "";
            string targetCollectionName = "t2i_presets";

            Console.WriteLine("SwarmUI Preset Deleter Tool");
            Console.WriteLine("-----------------------------\n");

            while (string.IsNullOrEmpty(swarmUIInstallDir))
            {
                Console.Write("Enter the *base directory* of your SwarmUI installation (e.g., 'E:\\SwarmUI' or '/path/to/SwarmUI'): ");
                string? input = Console.ReadLine(); // ReadLine returns a nullable string

                string trimmedInput = string.Empty; // Initialize trimmedInput to empty string

                if (input != null) // Check if input is not null before trimming
                {
                    trimmedInput = input.Trim(); // Now it's safe to trim
                }
                // If input *is* null, trimmedInput remains an empty string


                swarmUIInstallDir = trimmedInput; // Assign the trimmed (or empty) input to swarmUIInstallDir


                if (string.IsNullOrEmpty(swarmUIInstallDir))
                {
                    Console.WriteLine("Installation directory cannot be empty. Please try again.\n");
                }
                else if (!Directory.Exists(swarmUIInstallDir))
                {
                    Console.WriteLine($"Directory '{swarmUIInstallDir}' does not exist. Please check the path and try again.\n");
                    swarmUIInstallDir = ""; // Reset to prompt again
                }
                else
                {
                    dbPath = Path.Combine(swarmUIInstallDir, "Data", "Users.ldb");
                    if (!File.Exists(dbPath))
                    {
                        Console.WriteLine($"Error: 'Users.ldb' database file not found at the expected location:\n'{dbPath}'.\nPlease ensure you have entered the correct *base* SwarmUI installation directory.\n");
                        swarmUIInstallDir = ""; // Reset to prompt again
                        dbPath = "";
                    }
                }
            }

            Console.WriteLine($"\nUsing database path: '{dbPath}'\n");

            try
            {
                using (var db = new LiteDatabase(dbPath))
                {
                    var presetsCollection = db.GetCollection<BsonDocument>(targetCollectionName);

                    int initialCount = presetsCollection.Count();
                    Console.WriteLine($"Initial number of presets in '{targetCollectionName}': {initialCount}");

                    int deletedCount = presetsCollection.DeleteAll();

                    Console.WriteLine($"\nDeleted {deletedCount} presets from '{targetCollectionName}' collection.");

                    int finalCount = presetsCollection.Count();
                    Console.WriteLine($"Number of presets after deletion: {finalCount}");

                    if (finalCount == 0)
                    {
                        Console.WriteLine($"\nSuccessfully deleted all presets from '{targetCollectionName}'.");
                    }
                    else
                    {
                        Console.WriteLine($"\nWarning: Collection is not empty after deletion. Final count: {finalCount}. Something might have gone wrong.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during deletion: {ex.Message}");
                Console.WriteLine($"Details: {ex.ToString()}"); // Added more detailed error info for debugging
            }

            Console.WriteLine("\nDeletion process finished. Press any key to exit...");
            Console.ReadKey();
        }
    }
}