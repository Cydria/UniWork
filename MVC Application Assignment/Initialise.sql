create table Ambulances(
ambulance_ID varchar(4) not null primary key,
station varchar(30) not null);

create table StaffMember(
first_name varchar(60) not null,
surname varchar(30) not null,
officer_ID varchar(6) not null primary key,
skill_level varchar(30) not null,
assigned_ambulance varchar(10) default null,
foreign key (assigned_ambulance) references Ambulances (ambulance_ID));

insert into StaffMember values ('John', 'Doe', '135790', 'Basic', null);
insert into StaffMember values ('Peter', 'Smith', '135970', 'Basic', null);
insert into StaffMember values ('Jane', 'Doe', '131234', 'Intermediate', null);
insert into StaffMember values ('Bill', 'Bobbins', '133545', 'Intermediate', null);
insert into StaffMember values ('Carol', 'Green', '130001', 'Advanced', null);
insert into StaffMember values ('Jill', 'Shield', '132244', 'Basic', null);

insert into Ambulances values ('A7', 'Greenfields');
insert into Ambulances values ('A42', 'Bluelane');
insert into Ambulances values ('A110', 'Redville');