create database Task_WorkerMatching;
CREATE TABLE Client (
    client_id INT PRIMARY KEY,
    Name VARCHAR(10) NOT NULL,
    phone VARCHAR(11),
    Address VARCHAR(50),
    Email VARCHAR(20) UNIQUE NOT NULL,
    payment_info TEXT NOT NULL
);
CREATE TABLE Worker (
    Worker_ID INT PRIMARY KEY,
    Name VARCHAR(10) NOT NULL,
    Specialty_Name VARCHAR(50) NOT NULL
);
CREATE TABLE Task (
    TaskId INT PRIMARY KEY,
    taskname VARCHAR(50) NOT NULL,
    required_specialty VARCHAR(50)  NOT NULL,
    Average_Time_Needed FLOAT,
    Average_Task_Fee FLOAT
);
CREATE TABLE Service_Area (
    Area_ID INT PRIMARY KEY,
    Area_Name VARCHAR(50)
);
CREATE TABLE Worker_Service_Area (
    worker_Id INT  Foreign Key REFERENCES Worker(Worker_ID)  NOT NULL ,
    Area_ID INT Foreign Key REFERENCES Service_Area(Area_ID)  NOT NULL ,
);
CREATE TABLE Requests (
    Request_ID INT PRIMARY KEY,
    Request_placement_Time INT NOT NULL,
    Prefered_Time_Slot INT,
    Client_ID INT NOT NULL  FOREIGN KEY  REFERENCES Client(client_id),
    Worker_ID INT NOT NULL FOREIGN KEY  REFERENCES Worker(Worker_ID),
    Task_ID INT NOT NULL  FOREIGN KEY  REFERENCES Task(TaskId),
    Area_ID INT NOT NULL  FOREIGN KEY  REFERENCES Service_Area(Area_ID)
);
CREATE TABLE Worker_Availability (
    Availability_ID INT PRIMARY KEY,
    Worker_ID INT NOT NULL   FOREIGN KEY REFERENCES Worker(Worker_ID),
    Start_Time DATETIME NOT NULL,
    End_Time DATETIME NOT NULL
  
);
CREATE TABLE Rating (
    Request_ID INT UNIQUE NOT NULL FOREIGN KEY REFERENCES Requests(Request_ID),
    Rating_Type VARCHAR(20) NOT NULL ,
    Rating_Score FLOAT NOT NULL,
    Comment TEXT,
    Timestamp DATETIME NOT NULL,

);
