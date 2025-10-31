# Student-registration-system
A student registration system built with C# and Windows Forms. It allows entering student data such as name, gender, graduation year, GPA, major, skills, residence, birth date, phone number, and photo, displaying all records in an interactive DataGridView.
Student Registration System / نظام تسجيل طلاب
---
Project Overview:
A Windows Forms application built with C# that allows simple and clear management of student records. The form collects student details (full name, age, graduation year, GPA, languages, major, photo, birth date, and phone number) on one side and displays all registered students in an interactive DataGridView on the other side.

Features:
Add new student records with:
Full name (three parts), age, birth date
Graduation year, GPA
Major / specialization
Languages and language type (Arabic / English)
Phone number and residence
Attach a student photo (PictureBox)
Display all students in a DataGridView with ability to:
View records at a glance
Select a row to edit or delete (if implemented)


Basic input validation (recommended to implement):
Required fields, correct phone format, GPA numeric range
Simple, user-friendly Windows Forms interface


Requirements
Windows OS
Visual Studio (2017 / 2019 / 2022 or later)
.NET Framework compatible with the project (check the .csproj target)
(Optional) A local database or file storage (e.g., SQLite / SQL Server / CSV) if persistence is implemented


How to Run (step-by-step)
1. Download or clone the repository.
2. Open the solution file (.sln) in Visual Studio.
3. Ensure the target .NET Framework matches your environment. If not, retarget in Project Properties.
4. Build the solution: Build → Build Solution (or press Ctrl+Shift+B).
5. Run the application: Debug → Start Debugging (or press F5).
6. Use the form to enter student data on the right and see records on the left DataGridView.



Usage Notes
To persist data between runs, implement saving to a database (recommended) or to a file (JSON/CSV/XML). If current project uses in-memory list, data will be lost on app close.
Add .gitignore to avoid committing bin/ and obj/ folders.
Provide sample images in /Resources or allow user to browse local files.


Recommended Improvements (future)
Add edit and delete functionality with confirmation dialogs.
Add search and filter by name, major, or graduation year.
Implement persistent storage (SQLite or SQL Server).
Add export/import (CSV or Excel).
Add input masks (phone number) and stronger validation.
Localize UI strings fully (Arabic + English) with resource files.


Screenshots


License

This repository can use a permissive license such as MIT if you want others to reuse and learn from your code. To add MIT license, create LICENSE file with MIT text and update author/year.


---

نبذة عن المشروع
تطبيق سطح مكتب (Windows Forms) بلغة C# لإدارة بيانات الطلاب بطريقة بسيطة ومنظمة. النموذج يتيح إدخال بيانات الطالب على جهة اليمين (الاسم الثلاثي، العمر، تاريخ الميلاد، سنة التخرج، المعدل، التخصص، اللغات، رقم الهاتف، مكان السكن، وصورة الطالب)، وعلى الجهة الأخرى يعرض جدولًا تفاعليًا بكل الطلاب المسجلين.

المميزات
إضافة سجلات طلابية تتضمن:
الاسم الثلاثي، العمر، تاريخ الميلاد
سنة التخرج، المعدل (GPA)
التخصص، اللغات (وتحديد عربي/إنجليزي)
رقم الهاتف ومكان السكن
إرفاق صورة الطالب
عرض السجلات في DataGridView تفاعلي:
معاينة السجلات سريعًا
(يمكن إضافة تحرير وحذف السجلات)
تحقق أساسي من المدخلات (ينصح بتفعيله):
الحقول المطلوبة، تنسيق الهاتف، نطاق المعدل
واجهة مستخدم بسيطة وسهلة الاستخدام

المتطلبات
نظام تشغيل Windows
Visual Studio (2017 أو 2019 أو 2022 أو أحدثإطار عمل .NET مطابق لإعدادات المشروع (راجع .csproj)
(اختياري) قاعدة بيانات محلية أو تخزين ملفي (SQLite / SQL Server / CSV) للحفظ الدائم


طريقة التشغيل بالخطوات
1. نزّل أو انسخ المستودع (Download/Clone).
2. افتح ملف الحل .sln في Visual Studio.
3. تأكّد من أن إطار .NET متوافق مع بيئتك، وإن لزم عدّل الإعدادات في Project Properties.
4. بناء المشروع: Build → Build Solution أو Ctrl+Shift+B.
5. تشغيل التطبيق: Debug → Start Debugging أو F5.
6. استخدم النموذج لإدخال بيانات الطلاب على اليمين ومشاهدة السجلات على اليسار.


تحسينات مقترحة للمستقبل
إضافة وظائف التعديل والحذف مع مربعات تأكيد.
إضافة بحث وفلترة بالاسم أو التخصص أو سنة التخرج.
تنفيذ تخزين دائم (SQLite أو SQL Server).
إضافة استيراد/تصدير (CSV/Excel).
إضافة أقنعة إدخال (لرقم الهاتف) وتحسين التحقق من القيم.
دعم تعدد اللغات عبر ملفات الموارد (Localization) للعربية والإنجليزية.


الترخيص
يمكنك اعتماد ترخيص MIT إن رغبت أن يسمح الآخرون بإعادة استخدام المشروع والتعلم منه. لإضافة الترخيص أنشئ ملف LICENSE بنص MIT وغيّر اسم/سنة المؤلف.


---
