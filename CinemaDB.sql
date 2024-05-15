create database CinemaDB;
use CinemaDB;
go
create schema cinema;
go
create table cinema.Employee(
emp_id int IDENTITY(1,1) primary key,
emp_name varchar(100) not null,
emp_phone varchar(20) not null,
emp_dob date not null,
emp_gender varchar(10) not null,
emp_email varchar(150) unique not null,
emp_username varchar(100) unique not null,
emp_password varchar(100) not null,
emp_signedin char(3) default 'NO'
);

create table cinema.Movie(
movie_id int IDENTITY(1,1) primary key,
movie_name varchar(300) unique not null,
movie_minutes int not null,
movie_genre varchar(15) not null,
movie_releasedate date not null,
movie_poster image not null,
emp_id int foreign key references cinema.Employee(emp_id) on delete set null
);

create table cinema.cinemahall(
cinema_id int IDENTITY(1,1) primary key,
cinema_name char(1) not null,
cinema_capacity int not null default(20)
);

insert into cinema.cinemahall values ('A',20);
insert into cinema.cinemahall values ('B',15);
insert into cinema.cinemahall values ('C',10);

create table cinema.screening(
screening_id int IDENTITY(1,1) primary key,
screening_showtime time(0) not null,
screening_startdate date not null,
screening_enddate date not null,
movie_id int not null foreign key references cinema.movie(movie_id),
cinema_id int not null foreign key references cinema.cinemahall(cinema_id),
emp_id int foreign key references cinema.Employee(emp_id) on delete set null,
screening_isactive char(3) not null default 'YES'
);

create table cinema.Admin
(
	ad_id int IDENTITY(1,1) primary key,
	ad_username varchar(100) not null,
	ad_password varchar(100) not null,
	ad_signedin char(3) default 'NO'
);

create table cinema.Customer(
cust_id int IDENTITY(1,1) primary key,
cust_firstname varchar(50) not null,
cust_lastname varchar(50) not null,
cust_phone varchar(20) not null,
cust_dob date not null,
cust_email varchar(150) unique not null,
cust_username varchar(100) unique not null,
cust_password varchar(100) not null,
cust_signedin char(3) default 'NO'
);

Create table cinema.Seat (
seat_id int IDENTITY(1,1) PRIMARY KEY, 
seat_number int not null, 
seat_row char(1) not null, 
cinema_id int FOREIGN KEY references cinema.CinemaHall(cinema_id) not null
);

insert into cinema.Seat (seat_number,seat_row,cinema_id) values (1,'A',1), (2,'A',1),(3,'A',1),(4,'A',1),(5,'A',1),(6,'A',1),(7,'A',1),(8,'A',1),(9,'A',1),(10,'A',1),(11,'B',1),(12,'B',1),(13,'B',1),(14,'B',1),(15,'B',1),(16,'B',1),(17,'B',1),(18,'B',1),(19,'B',1),(20,'B',1);
insert into cinema.Seat (seat_number,seat_row,cinema_id) values (1,'A',2), (2,'A',2),(3,'A',2),(4,'A',2),(5,'A',2),(6,'B',2),(7,'B',2),(8,'B',2),(9,'B',2),(10,'B',2),(11,'C',2),(12,'C',2),(13,'C',2),(14,'C',2),(15,'C',2);
insert into cinema.Seat (seat_number,seat_row,cinema_id) values (1,'A',3), (2,'A',3),(3,'A',3),(4,'A',3),(5,'A',3),(6,'B',3),(7,'B',3),(8,'B',3),(9,'B',3),(10,'B',3);

Create table cinema.PaymentMethod (
paymthd_id int IDENTITY(1,1) PRIMARY KEY, 
paymthd varchar(100) unique not null
);

insert into cinema.PaymentMethod (paymthd) values ('Cash'),('Credit Card'),('Easy Paisa'), ('Jazz Cash');

Create table cinema.Transactions (
	tr_id int IDENTITY(1,1) PRIMARY KEY, 
	tr_amount decimal not null,
	tr_date date not null,
	tr_tickquantity int not null,
	screening_id int FOREIGN KEY references cinema.Screening(screening_id) not null,
	cust_id int FOREIGN KEY references cinema.Customer(cust_id) not null,
	paymthd_id int FOREIGN KEY references cinema.PaymentMethod(paymthd_id) not null,
);


Create table cinema.Ticket (
tick_id int IDENTITY(1,1) PRIMARY KEY, 
tick_showdate date not null,
seat_id int FOREIGN KEY references cinema.Seat(seat_id) not null, 
cust_id int FOREIGN KEY references cinema.Customer(cust_id) not null, 
tr_id int FOREIGN KEY references cinema.Transactions(tr_id) not null,
screening_id int FOREIGN KEY references cinema.Screening(screening_id) not null
);
