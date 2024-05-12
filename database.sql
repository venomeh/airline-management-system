CREATE TABLE LOGIN_TYPE
(
   type_no INT PRIMARY KEY,
   type_name VARCHAR(20)
)

CREATE TABLE LOGIN_DETAILS
(
    login_id INT PRIMARY KEY,
    email VARCHAR2(200) UNIQUE NOT NULL,
    password VARCHAR2(255) NOT NULL,
    user_typeno NUMBER(1),  
    
    CONSTRAINT FKtypeno FOREIGN KEY (user_typeno) REFERENCES LOGIN_TYPE(type_no)
  
);

CREATE TABLE USER_TABLE 
(
    person_name VARCHAR2(255),
    cnic VARCHAR2(13) PRIMARY KEY,
    email VARCHAR2(200) UNIQUE NOT NULL,
    phone_num INT UNIQUE NOT NULL, 
    
    loginID INT,
    CONSTRAINT FK_UID FOREIGN KEY (loginID) REFERENCES LOGIN_DETAILS(login_id)
    ON DELETE SET NULL
);

CREATE SEQUENCE pass_id_seq start with 1000;;

-- passenger table
CREATE TABLE PASSENGERS 
(
  pass_id NUMBER PRIMARY KEY,
  disability NUMBER(1) NOT NULL, 
  emergency_contact NUMBER NOT NULL,
  
  cnic NUMBER NOT NULL,
  CONSTRAINT FK_CNIC FOREIGN KEY (cnic) REFERENCES USER_TABLE(cnic)
  ON UPDATE CASCADE 
);

--employee table (fk-user_table)
CREATE table EMPLOYEE(
	
	emp_id serial primary key,
	performance int,
	experience int NOT NULL,
	occupation char NOT NULL,
	salary int NOT NULL,
	age int,
	cnic int,
  
    constraint U_id_fk FOREIGN KEY (cnic) REFERENCES USER_TABLE(cnic)
    ON UPDATE CASCADE,
	
	constraint chk_occupation check(occupation IN ('C','S')),
	
	constraint chk_performance check(performance::integer BETWEEN 10 AND 100),
	
	constraint chk_exp check(experience::integer BETWEEN 0 AND 35)
);

