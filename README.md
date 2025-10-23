# 🚀 C# User Data Entry Form (WinForms)

This project is a simple, yet robust, Windows Forms (WinForms) application developed in **C#** for user data entry. It demonstrates basic UI design principles, event handling, and data validation techniques commonly used in desktop application development.

The form, titled **"User Information Form Sample"** (نمون برگ اطلاعات کاربر), is designed to collect and validate standard user details.

## ✨ Key Features

* **Comprehensive Data Fields:** Fields for Name, Last Name, Username, Password, Password Confirmation, and Address.
* **Input Validation:** Real-time and submission-time validation checks for field length and password matching.
* **Password Toggle:** "Show/Hide" functionality for both password fields using an eye emoji ($\text{👁️/🙈}$).
* **Sequential Input:** Seamless navigation between text fields using the **Enter** key.
* **UI Customization:** Users can dynamically change the form's **background color** and the **font/color of the text** using built-in Windows dialogs ($\text{ColorDialog}$ and $\text{FontDialog}$).
* **Image Upload:** Functionality to load a user image into the $\text{PictureBox}$.
* **Form Actions:** Dedicated buttons for **Register** (ثبت), **Clear** (حذف), and **Exit** (خروج).

---

## ⚙️ Technical Details & Validation Logic

The application logic is primarily contained within the `Form1.cs` file under the `entrance` namespace.

### Validation Rules

| Field | $\text{TextBox}$ Name | Rule | Action on Error |
| :--- | :--- | :--- | :--- |
| **Username** (نام کاربری) | $\text{textBox3}$ | Max length **5** characters. | Prompts user to clear the field. |
| **Name** (نام کاربر) | $\text{textBox1}$ | Max length **10** characters. | Prompts user to clear the field. |
| **Password** (گذرواژه) | $\text{textBox4}$ | Max length **8** characters. | Prompts user to clear the field. |
| **Password Repeat** | $\text{textBox5}$ | Must **match** $\text{textBox4}$'s content. | Prompts user to clear the confirmation field. |
| **All Fields** | - | Cannot be **empty**. | Displays a warning $\text{MessageBox}$. |

### Control Mapping (based on code)

The form utilizes several controls mapped to specific actions:

* **Registration Button (ثبت):** `button1_Click_1` - Handles all final data validation.
* **Exit Button (خروج):** `button2_Click` - Closes the form (`Close()`).
* **Clear Button (حذف):** `button3_Click` - Clears the text from all six input fields.
* **Image Upload Button (بارگذاری تصویر):** `button5_Click` - Opens an $\text{OpenFileDialog}$ to select JPG or PNG images and displays the image in $\text{pictureBox1}$.
* **Change Color Button (تغییر رنگ فرم):** `button6_Click` - Displays a $\text{ColorDialog}$ and sets the form's $\text{BackColor}$.
* **Change Font Button (تغییر فونت فرم):** `button7_Click` - Displays a $\text{FontDialog}$ and applies the selected font and $\text{ForeColor}$ to the entire form.
* **Password Toggle Buttons:** $\text{btnpassword\_Click}$ (for $\text{textBox4}$) and $\text{button4\_Click}$ (for $\text{textBox5}$) toggle the `UseSystemPasswordChar` property.

---

## 🚀 Getting Started

To run this project:

1.  **Clone the repository** (or download the code files).
2.  Open the $\text{.csproj}$ file in **Visual Studio** (requires $\text{.NET Framework 4.5}$ or compatible version).
3.  Set **$\text{Form1}$** as the startup object if needed.
4.  Press **F5** to build and run the application in Debug mode.

---

## 📸 Form Preview

Here is a glimpse of the user interface:


---

## 🤝 Contribution

Feel free to **fork** this repository, open **Issues** for suggestions or bugs, or submit **Pull Requests** with improvements to the validation logic or UI/UX!
