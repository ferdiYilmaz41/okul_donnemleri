--create database VTYSUyg3
--use VTYSUyg3

--create table departments(
--department_id int not null,
--department_name varchar(255) null
--);

--alter table departments add primary key (department_id)

--create table jobs(
--job_id int not null,
--job_title varchar(255) null,
--min_salary int null,
--max_salary int null
--)

--alter table jobs add primary key (job_id)

--create table employees(
--employee_id varchar(255) not null,
--first_name varchar(255) null,
--last_name varchar(255) null,
--email varchar(255) null,
--phone_number int null,
--salary int null,
--job_id int not null,
--department_id int not null,
--FK_employee_id varchar(255) null,
--Manager_ID varchar(255) null
--)

--alter table employees add primary key (employee_id);
--alter table employees add foreign key (job_id) references jobs(job_id);
--alter table employees add foreign key (department_id) references departments(department_id)
--alter table employees add foreign key (FK_employee_id) references employees(employee_id)



--insert into departments values(101,'Department_A')
--insert into departments values(102,'Department_B')


--insert into jobs values(1,'Executive',2500,3000)
--insert into jobs values(2,'Executive Assistant',2000,2500)


--insert into employees (employee_id,
--first_name,
--last_name, 
--email,
--phone_number,
--salary, 
--job_id,
--department_id) values ('E1001','Ayþe','Ayaz','aa@mail.net',1011,3000,1,101)
--insert into employees (employee_id, 
--first_name, 
--last_name, 
--email,
--phone_number, 
--salary,
--job_id,
--department_id) values ('E1002','Burak','Bilir','bb@mail.net',2022,2750,1,102)
--insert into employees (employee_id,
--first_name, 
--last_name,
--email, 
--phone_number,
--salary,
--job_id,
--department_id) values ('E1003','Canan','Can','cc@mail.net',3033,2500,2,101)
--insert into employees (employee_id,
--first_name,
--last_name,
--email, 
--phone_number,
--salary,
--job_id,
--department_id) values ('E1004','Delil','Doðru','dd@mail.net',4044,2250,2,102)


--select* from Departments
--SELECT DISTINCT job_id FROM jobs;
--SELECT * FROM jobs J, employees E WHERE J.job_id = E.job_id AND J.Job_Title = 'Executive Assistant'
--SELECT E.first_name, E.last_name, E.salary FROM departments D, employees E WHERE E.Department_id = D.Department_id AND D.Department_Name = 'Department_B'
--SELECT E.first_name FROM employees E, departments D, jobs J WHERE E.job_id = J.job_id AND E.department_id = D.department_id AND J.job_title = 'Executive' AND D.department_name = 'Department_B';
--SELECT first_name, last_name, salary FROM employees E, departments D WHERE D.department_id = E.department_id AND D.department_name = 'Department_B' ORDER BY salary Desc;