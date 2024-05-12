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

CREATE TABLE EMPLOYEE (
    emp_id NUMBER PRIMARY KEY,
    performance INT,
    experience INT NOT NULL,
    occupation CHAR NOT NULL,
    salary INT NOT NULL,
    age INT,
    cnic VARCHAR(13) NOT NULL,

    CONSTRAINT User_table_fk FOREIGN KEY (cnic) REFERENCES USER_TABLE(cnic),
    
	CONSTRAINT chk_occupation CHECK (occupation IN ('C', 'S')),
    
	CONSTRAINT chk_performance CHECK (performance BETWEEN 10 AND 100),
    
	CONSTRAINT chk_exp CHECK (experience BETWEEN 0 AND 35)
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
	
	emp_id int NOT NULL,
	constraint emp_fk foreign key(emp_id) references EMPLOYEE(emp_id)
);




-- aircraft table :: aircraft details

CREATE SEQUENCE aircraft_id_seq
  INCREMENT BY 1
  START WITH 1000
  MAXVALUE 999999999
  NOCACHE
  NOCYCLE
  ORDER;
  
create table aircraft
(
	aircraft_id number primary key,
	capacity_ratio int NOT NULL,
	total_capacity int NOT NULL,
	
	constraint chk_ratio check(capacity_ratio between 20 AND 70)
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

CREATE TABLE maintainance (
    m_id NUMBER PRIMARY KEY,
    task_description CHAR NOT NULL,
    maintainance_cost INT NOT NULL,
    start_date DATE NOT NULL,
    end_date DATE NOT NULL,
    status NUMBER(1) NOT NULL,
    aircraft_id NUMBER,
    CONSTRAINT fk_aircraft FOREIGN KEY (aircraft_id) REFERENCES aircraft(aircraft_id)
);




-- flight table 

CREATE SEQUENCE flight_id_seq
  INCREMENT BY 1
  START WITH 3000
  MAXVALUE 999999999
  NOCACHE
  NOCYCLE
  ORDER;

CREATE TABLE flight (  
    flight_id NUMBER PRIMARY KEY,
    departure_city varchar(20) NOT NULL,
    arrival_city varchar(20) NOT NULL,
    departure_time TIMESTAMP NOT NULL,
    arrival_time TIMESTAMP NOT NULL,
    revenue INT, --trigger pending
    flight_status CHAR NOT NULL, --trigger pending

    aircraft_id NUMBER,
    CONSTRAINT fk_aircraft_ID FOREIGN KEY (aircraft_id) REFERENCES aircraft(aircraft_id)
);


--generates revenue (associative entity) -> flight,aircraft,maintainance

CREATE TABLE generates_revenue (
    revenue_generated INT, -- Trigger pending
    status_of_flight VARCHAR2(10), -- Trigger pending
    total_cost INT, -- Trigger pending
    airtime_cost INT, -- Trigger pending

    flight_id NUMBER,
    aircraft_id NUMBER,
    m_id NUMBER,
    
    CONSTRAINT flightID_fk FOREIGN KEY (flight_id) REFERENCES flight (flight_id),
    CONSTRAINT aircraftID_fk FOREIGN KEY (aircraft_id) REFERENCES aircraft (aircraft_id),
    CONSTRAINT maintainanceID_fk FOREIGN KEY (m_id) REFERENCES maintainance (m_id),
    
    PRIMARY KEY (flight_id, aircraft_id, m_id)
);




-- crew table (fk-flight)

CREATE SEQUENCE crew_id_seq
  INCREMENT BY 1
  START WITH 4000
  MAXVALUE 999999999
  NOCACHE
  NOCYCLE
  ORDER;

CREATE TABLE crew (
    crew_id NUMBER PRIMARY KEY,
    
    emp_id INT,
    CONSTRAINT crewEmp_fk FOREIGN KEY (emp_id) REFERENCES employee (emp_id),
    flight_id INT,
    CONSTRAINT crewflightID_fk FOREIGN KEY (flight_id) REFERENCES flight (flight_id)
);


-- baggage table (fk-PASSENGERS),(fk-flight)

CREATE SEQUENCE bag_id_seq
  INCREMENT BY 1
  START WITH 5000
  MAXVALUE 999999999
  NOCACHE
  NOCYCLE
  ORDER;

CREATE TABLE baggage (
    baggage_id NUMBER PRIMARY KEY,
    claim_status NUMBER(1),
    bag_weight_cost INT,
    weight INT,
    pass_id INT,
    flight_id INT,
    
    CONSTRAINT baggagePass_fk FOREIGN KEY (pass_id) REFERENCES passengers (pass_id),
    CONSTRAINT baggageFlight_fk FOREIGN KEY (flight_id) REFERENCES flight (flight_id)
);


--booking table (associative entity) -> flight, passengers, baggage
CREATE TABLE booking (
    seat_no INT NOT NULL,
    booking_date DATE NOT NULL,
    ticket_price INT NOT NULL,
    class_book NUMBER(1) NOT NULL,

    flight_id INT,
    passenger_id INT,
    baggage_id INT,

    CONSTRAINT bookingFlight_fk FOREIGN KEY (flight_id) REFERENCES flight (flight_id),
    CONSTRAINT bookingPass_fk FOREIGN KEY (passenger_id) REFERENCES passengers (pass_id),
    CONSTRAINT bookingBaggage_fk FOREIGN KEY (baggage_id) REFERENCES baggage (baggage_id)
);
