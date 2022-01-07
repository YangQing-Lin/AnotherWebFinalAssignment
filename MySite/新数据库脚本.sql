create database SCMS
go
use SCMS
go
--用户信息
create table UserInfo
(
id nvarchar(20) not null primary key,--编号
name nvarchar(20) not null,--姓名
pwd nvarchar(50) not null,--密码
sex nvarchar(5) not null--性别
)
go

insert into userInfo values('admin','admin','123456',N'男')
go

--学生选课表
create table CourseInfo
(
id int not null primary key, --主键
name nvarchar(100) not null,--课程名称
kcms nvarchar(500) not null,--课程描述
xkrq DATETIME not null,--选课日期
xkxs NVARCHAR(20) not null  --选课学生
)
go

insert into courseInfo values(1, 'Web网页开发', '学习如何制作网页', '2021-12-18 00:00:00.000', '林晴川')
go

