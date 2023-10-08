USE sysacad_db;

INSERT INTO users (us_name, us_password, us_role)
VALUES
('admin1', 'admin1', 1),
('12345', 'student1', 2),
('admin2', 'admin2', 1),
('54321', 'student2', 2),
('admin3', 'admin3', 1),
('67890', 'student3', 2); 

INSERT INTO students (st_name, st_surname, st_file_number, st_address, st_phone_number, st_email_account, st_change_password)
VALUES
('student1', 'surname1', 12345, 'address1', '123-456-7890', 'student1@example.com', 1),
('student2', 'surname2', 54321, 'address2', '987-654-3210', 'student2@example.com', 0),
('student3', 'surname3', 67890, 'address3', '555-555-5555', 'student3@example.com', 1),
('student4', 'surname4', 98765, 'address4', '444-444-4444', 'student4@example.com', 0),
('student5', 'surname5', 13579, 'address5', '999-999-9999', 'student5@example.com', 1);

INSERT INTO payments (py_st_file_number, py_concept, py_amount, py_settled)
VALUES
(12345, 'Payment1', 500, 1),
(54321, 'Payment2', 600, 0),
(67890, 'Payment3', 450, 1),
(98765, 'Payment4', 700, 1),
(13579, 'Payment5', 550, 0);

INSERT INTO subjects (sb_code, sb_name, sb_head_professor)
VALUES
(1101,"Subject1","Profesor1"),
(1102,"Subject2","Profesor2"),
(1103,"Subject3","Profesor3"),
(1104,"Subject4","Profesor4"),
(1105,"Subject5","Profesor5");

INSERT INTO courses (cr_subject_name, cr_code, cr_description, cr_maximum_quota, cr_days, cr_class_room, cr_hr_from, cr_hr_until, cr_shift, cr_sb_code)
VALUES
('Course1', 101, 'Description of Course 1', 30, 110100, 301, 1, 5, 1, 1101),
('Course2', 102, 'Description of Course 2', 25, 100101, 302, 1, 5, 2, 1102),
('Course3', 103, 'Description of Course 3', 20, 110100, 303, 1, 5, 3, 1103),
('Course4', 104, 'Description of Course 4', 35, 100100, 304, 1, 3, 1, 1104),
('Course5', 105, 'Description of Course 5', 28, 100001, 305, 1, 3, 2, 1105);

INSERT INTO enrollments (er_st_file_number, er_cr_code, er_subject_name, er_class_room, er_creation_date, er_days, er_hr_from, er_hr_until, er_shift)
VALUES
(12345, 101, 'Course1', 301, '2023-01-01', 110100, 1, 5, 1),
(54321, 102, 'Course2', 302, '2023-02-01', 100101, 1, 5, 2),
(67890, 103, 'Course3', 303, '2023-03-01', 110100, 1, 5, 3),
(98765, 104, 'Course4', 304, '2023-04-01', 100100, 1, 5, 1),
(13579, 105, 'Course5', 305, '2023-05-01', 100001, 1, 5, 2);
