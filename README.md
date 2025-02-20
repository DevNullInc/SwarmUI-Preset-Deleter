# SwarmUI Preset Deleter Tool

## **WARNING: Data Deletion - Use with Extreme Caution!**

**This tool will PERMANENTLY DELETE all your Text-to-Image (T2I) presets from your SwarmUI `Users.ldb` database file.**

**It is designed for users who want to completely clear out their existing presets and start fresh.**

**IMPORTANT:** To avoid data loss and potential issues, please carefully follow these instructions.  Ensure you **EXPORT** your presets from SwarmUI *before* running this tool if you wish to keep any of them.  **Data deletion is irreversible without a backup!**

---

## How to Use

### Preparation - Important Steps Before Running

Before running the Preset Deleter tool, it is **critical** to perform these preparation steps:

#### 1. **Backup Your `Users.ldb` File!**

*   Locate your `Users.ldb` file. This is typically found in the `Data` folder within your SwarmUI installation directory (e.g., `E:\SwarmUI\Data\Users.ldb` or `/path/to/SwarmUI/Data/Users.ldb`).
*   **Make a backup copy of this `Users.ldb` file** and store it in a safe location. You will need this backup to restore your presets if something goes wrong or you change your mind.

#### 2. **Export Your Current Presets (If You Want to Keep Any)**

*   **Open SwarmUI.**
*   **Navigate to the "Presets" tab** within SwarmUI.
*   **Click the "Export All Presets" button.**  (See screenshot in the main repository README for visual guidance if needed).
*   **Save the exported presets file** (usually a `.json` file) to a safe and memorable location on your computer.

#### 3. **Shut Down SwarmUI Completely**

*   **Close SwarmUI entirely.** Ensure that SwarmUI is **not running in the background**. The Preset Deleter tool cannot access the database if SwarmUI is running.

---

### Running the Preset Deleter Tool

Once you have completed the preparation steps:

#### 4. **Download the Executable**

*   Download the `SwarmUIPresetDeleter.exe` file (and any associated `.dll` files if provided in a ZIP archive) from the latest release on this GitHub repository.

#### 5. **Place the Executable in the Correct Folder**

*   Place the downloaded `SwarmUIPresetDeleter.exe` file in the **same folder** where your `Users.ldb` file is located.  For example, if `Users.ldb` is in `E:\Data\Packages\SwarmUI\Data\`, place `SwarmUIPresetDeleter.exe` in the same `Data` folder.

#### 6. **Run `SwarmUIPresetDeleter.exe`**

*   **Double-click** on `SwarmUIPresetDeleter.exe` to run it.  A command prompt window will appear.

#### 7. **Enter Your SwarmUI Installation Directory**

*   When prompted in the command prompt window, **carefully enter the *base directory* of your SwarmUI installation.**  This is the main folder where SwarmUI is installed (e.g., `E:\SwarmUI` or `/path/to/SwarmUI`).  **Do not enter the `Data` folder path - just the base SwarmUI directory.**

#### 8. **Check the Output in the Command Prompt**

*   Observe the command prompt window. It will display messages indicating the process.  It should show:
    * The initial number of presets found.
    * The number of presets deleted.
    * The final number of presets (which should be 0).
    * A "Successfully deleted all presets..." message.

#### 9. **Press Any Key to Exit**

*   Once you see the "Deletion process finished" message, press any key to close the command prompt window.

---

### Post-Deletion Steps

After running the Preset Deleter tool:

#### 10. **Restart SwarmUI**

*   Launch SwarmUI again.

#### 11. **Verify Presets Are Gone in SwarmUI**

*   Go to the "Presets" tab in SwarmUI. You should confirm that your presets have been removed and the list is now empty.

#### 12. **Re-import Presets (If You Exported Them Earlier)**

*   If you exported your presets in **Step 2** and wish to restore them, in the "Presets" tab in SwarmUI, click the "Import Presets" button.
*   Select the `.json` file you saved earlier and import your desired presets back into SwarmUI.

---

## Disclaimer

This tool is provided "as-is" without any warranty, express or implied. Use it at your own risk. The author is not responsible for any data loss, system instability, or other issues resulting from the use or misuse of this tool.  **Always back up your data and follow the instructions carefully.**

**Target Runtime:** This executable was built for Windows 64-bit (`win-x64`).

---

**Action for You:**

1.  **Replace the content of your `README.md` file with the improved Markdown text above.**
2.  **Review the Markdown formatting in your GitHub repository** to make sure it renders correctly as intended. GitHub will automatically format Markdown.

This enhanced `README.md` should be significantly more readable and user-friendly on GitHub, making it much easier for users to understand and safely use your SwarmUI Preset Deleter tool!
