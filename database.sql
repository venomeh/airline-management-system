# by default set will not change 
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
    phone_num INT NOT NULL, 
    
    loginID INT,
    CONSTRAINT FK_UID FOREIGN KEY (loginID) REFERENCES LOGIN_DETAILS(login_id)
    ON DELETE SET NULL
);

CREATE TABLE PASSENGERS (
    pass_id NUMBER PRIMARY KEY,  
    disability NUMBER(1) CHECK (disability IN (0,1)) NOT NULL,
    emergency_contact VARCHAR2(20) NOT NULL,
    cnic VARCHAR2(13) NOT NULL,
    CONSTRAINT FK_CNIC FOREIGN KEY (cnic) REFERENCES USER_TABLE(cnic)
);

CREATE OR REPLACE TRIGGER passengers_bir 
BEFORE INSERT ON PASSENGERS 
FOR EACH ROW
DECLARE
    max_pass_id NUMBER;
BEGIN
    -- Get the maximum pass_id from the PASSENGERS table
    SELECT MAX(pass_id) INTO max_pass_id FROM PASSENGERS;

    -- If max_pass_id is null, set it to 0
    IF max_pass_id IS NULL THEN
        max_pass_id := 0;
    END IF;

    -- Set the new pass_id to max_pass_id + 1
    :new.pass_id := max_pass_id + 1;
END;
/






--employee table (fk-user_table)

CREATE SEQUENCE emp_id_seq
  INCREMENT BY 1
  START WITH 6000
  MAXVALUE 999999999
  NOCACHE
  NOCYCLE
  ORDER;

CREATE table EMPLOYEE(
	
	emp_id NUMBER primary key DEFAULT emp_id_seq.NEXTVAL,
	performance int,
	experience int NOT NULL,
	occupation char NOT NULL,
	salary int NOT NULL,
	age int,
	cnic int,

    constraint User_table_fk FOREIGN KEY (cnic) REFERENCES USER_TABLE(cnic),
	
	constraint chk_occupation check(occupation IN ('C','S')),
	
	constraint chk_performance check(performance::integer BETWEEN 10 AND 100),
	
	constraint chk_exp check(experience::integer BETWEEN 0 AND 35)
);



-- staff table (fk-employee)

CREATE SEQUENCE staff_id_seq
  INCREMENT BY 1
  START WITH 7000
  MAXVALUE 999999999
  NOCACHE
  NOCYCLE
  ORDER;

create table staff(
	staff_id number primary key default staff_id_seq.NEXTVAL,
	staff_role VARCHAR(100) NOT NULL,
	
	emp_id int,
	constraint emp_fk foreign key(emp_id) references emp(emp_id)
);




-- aircraft table :: aircraft details

CREATE SEQUENCE aircraft_id_seq
  INCREMENT BY 1
  START WITH 1000
  MAXVALUE 999999999
  NOCACHE
  NOCYCLE
  ORDER;

create table aircraft(
	aircraft_id number primary key default aircraft_id_seq.NEXTVAL,
	capacity_ratio int NOT NULL,
	total_capacity int NOT NULL,
	
	constraint chk_ratio check(capacity_ratio::int between 20 AND 70)
);

create table aircraft_details (
	airline_company varchar(255) primary key,
	cost_per_hour int NOT NULL,

	aircraft_id NUMBER,
	constraint aircraft_fk foreign key(aircraft_id) references aircraft(aircraft_id)
);




--maintainance table (fk-aircraft)

CREATE SEQUENCE maintainance_id_seq
  INCREMENT BY 1
  START WITH 2000
  MAXVALUE 999999999
  NOCACHE
  NOCYCLE
  ORDER;

create table maintainance (
	m_id number primary key default maintainance_id_seq.NEXTVAL,
	task_description char NOT NULL,
	maintainance_cost int NOT NULL,
	start_date date NOT NULL,
	end_date date NOT NULL,
	status bool NOT NULL,
	
	aircraft_id NUMBER,
	constraint fk_aircraft foreign key (aircraft_id) references aircraft(aircraft_id)
);




-- flight table 

CREATE SEQUENCE flight_id_seq
  INCREMENT BY 1
  START WITH 3000
  MAXVALUE 999999999
  NOCACHE
  NOCYCLE
  ORDER;

create table flight(  -----changes needed
	flight_id NUMBER primary key default flight_id_seq.NEXTVAL,
	departure date NOT NULL,
	arrival date NOT NULL,
	departure_time time NOT NULL,
	arrival_time time NOT NULL,
	revenue int, --trigger pending
	flight_status char NOT NULL, --triggger pending
	
	aircraft_id NUMBER,
	constraint fk_aircraft foreign key (aircraft_id) references aircraft(aircraft_id)
);



--generates revenue (associative entity) -> flight,aircraft,maintainance

create table generates_revenue(
	revenue_generated int, --trigger pending
	status_of_flight varchar(10), --trigger pending
	total_cost int, --triggger pending
	airtime_cost int, --trigger pending
	
	flight_id NUMBER,
	aircraft_id NUMBER,
	m_id NUMBER,
	constraint flight_fk foreign key(flight_id) references flight(flight_id),
	constraint aircraft_fk foreign key(aircraft_id) references aircraft(aircraft_id),
	constraint maintainance_fk foreign key(m_id) references maintainance(m_id),
	
	primary key(flight_id,aircraft_id,m_id)

);




-- crew table (fk-flight)

CREATE SEQUENCE crew_id_seq
  INCREMENT BY 1
  START WITH 4000
  MAXVALUE 999999999
  NOCACHE
  NOCYCLE
  ORDER;

create table crew(
	crew_id NUMBER primary key DEFAULT crew_id_seq.NEXTVAL ,

	emp_id int,
	constraint emp_fk foreign key(emp_id) references emp(emp_id),
	
	flight_id int,
	constraint flight_fk foreign key(flight_id) references flight
);



-- baggage table (fk-PASSENGERS),(fk-flight)

CREATE SEQUENCE bag_id_seq
  INCREMENT BY 1
  START WITH 5000
  MAXVALUE 999999999
  NOCACHE
  NOCYCLE
  ORDER;

create table baggage(
	baggage_id NUMBER primary key default bag_id_seq.NEXTVAL,
	claim_status bool,
	bag_weight_cost int,
	weight int,
	
	pass_id int,
	flight_id int,
	
	constraint pass_fk foreign key(pass_id) references passengers(pass_id),
	constraint flight_fk foreign key(flight_id) references flight(flight_id)
);



--booking table (associative entity) -> flight, passengers, baggage

create table booking(
	seat_no int not null,
	booking_date date not null,
	ticket_price int not null,
	class_Book bool not null,
	
	flight_id int,
	passenger_id int,
	baggage_id int,
	
	constraint flight_fk foreign key(flight_id) references flight(flight_id),
	constraint pass_fk foreign key(passenger_id) references passengers(pass_id),
	constraint baggage_fk foreign key(baggage_id) references baggage(baggage_id)
);