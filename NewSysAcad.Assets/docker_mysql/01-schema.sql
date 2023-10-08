USE sysacad_db;
CREATE TABLE users (
    id INT AUTO_INCREMENT PRIMARY KEY,
    us_name VARCHAR(255),
    us_password VARCHAR(255),
    us_role INT
);

CREATE TABLE students (
    id INT AUTO_INCREMENT PRIMARY KEY,
    st_name VARCHAR(255),
    st_surname VARCHAR(255),
    st_file_number INT UNIQUE,
    st_address VARCHAR(255),
    st_phone_number VARCHAR(20),
    st_email_account VARCHAR(255),
    st_change_password BOOLEAN
);

CREATE TABLE payments (
    id INT AUTO_INCREMENT PRIMARY KEY,
    py_st_file_number INT,
    py_concept VARCHAR(255),
    py_amount INT,
    py_settled BOOLEAN,
    FOREIGN KEY (py_st_file_number) REFERENCES students(st_file_number)
);

CREATE TABLE subjects (
    id INT AUTO_INCREMENT PRIMARY KEY,
    sb_code INT UNIQUE,
    sb_name VARCHAR(255),
    sb_head_professor VARCHAR(255)
);

CREATE TABLE courses (
    id INT AUTO_INCREMENT PRIMARY KEY,
    cr_subject_name VARCHAR(255),
    cr_code INT UNIQUE,
    cr_description VARCHAR(255),
    cr_maximum_quota INT,
    cr_days INT,
    cr_class_room INT,
    cr_hr_from INT,
    cr_hr_until INT,
    cr_shift INT,
    cr_sb_code INT,
    FOREIGN KEY (cr_sb_code) REFERENCES subjects(sb_code)
);

CREATE TABLE enrollments (
    id INT AUTO_INCREMENT PRIMARY KEY,
    er_st_file_number INT,
    er_cr_code INT,
    er_subject_name VARCHAR(255),
    er_class_room INT,
    er_creation_date DATE,
    er_days INT,
    er_hr_from INT,
    er_hr_until INT,
    er_shift INT,
    FOREIGN KEY (er_st_file_number) REFERENCES students(st_file_number),
    FOREIGN KEY (er_cr_code) REFERENCES courses(cr_code)
);
