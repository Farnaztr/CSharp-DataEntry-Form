# -C# User Data Entry Form (WinForms)

This project is a simple, yet robust, Windows Forms (WinForms) application developed in **C#** for user data entry. It demonstrates basic UI design principles, event handling, and data validation techniques commonly used in desktop application development.

The form, titled **"User Information Form Sample"** (نمون برگ اطلاعات کاربر), is designed to collect and validate standard user details.

## Key Features

* **Comprehensive Data Fields:** Fields for Name, Last Name, Username, Password, Password Confirmation, and Address.
* **Input Validation:** Real-time and submission-time validation checks for field length and password matching.
* **Password Toggle:** "Show/Hide" functionality for both password fields using an eye emoji ($\text{👁️/🙈}$).
* **Sequential Input:** Seamless navigation between text fields using the **Enter** key.
* **UI Customization:** Users can dynamically change the form's **background color** and the **font/color of the text** using built-in Windows dialogs ($\text{ColorDialog}$ and $\text{FontDialog}$).
* **Image Upload:** Functionality to load a user image into the $\text{PictureBox}$.
* **Form Actions:** Dedicated buttons for **Register** (ثبت), **Clear** (حذف), and **Exit** (خروج).

---

## Technical Details & Validation Logic

The application logic is primarily contained within the `Form1.cs` file under the `entrance` namespace.


### Validation Rules

| Field | $\text{TextBox}$ Name | Rule | Action on Error |
| :--- | :--- | :--- | :--- |
| **Username** (نام کاربری) | $\text{textBox3}$ | Max length **5** characters. | Prompts user to clear the field. |
| **Name** (نام کاربر) | $\text{textBox1}$ | Max length **10** characters. | Prompts user to clear the field. |
| **Password** (گذرواژه) | $\text{textBox4}$ | Max length **8** characters. | Prompts user to clear the field. |
| **Password Repeat** | $\text{textBox5}$ | Must **match** $\text{textBox4}$'s content. | Prompts user to clear the confirmation field. |
| **All Fields** | - | Cannot be **empty**. | Displays a warning $\text{MessageBox}$. |



---

## Form Preview

Here is a glimpse of the user interface:

<img width="400" height="300" alt="image" src="https://github.com/user-attachments/assets/afaf7557-b23d-43a0-b642-7b4a35fe1eb7" />

---
