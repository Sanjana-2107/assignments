create database sale
create table salestable
(
name varchar(25),
sales_id int,
Tutuorial_id int,
salesdate date
) 
insert into salestable values ('sanjana',1,100,'2015-10-10')
insert into salestable values ('prakash',2,200,'2017-1-19')
insert into salestable values ('sahana',3,300,'1997-08-14')
insert into salestable values ('john',4,400,'1999-07-21')

select *from salestable
select datename (mm,salesdate) ,datename (yyyy,salesdate),datename (DD,salesdate)from salestable
select DATEPART (mm,salesdate) ,datepart (yyyy,salesdate),datepart (DD,salesdate)from salestable
select DATEADD (mm,7,salesdate),DATEADD (YYYY,10,salesdate),DATEADD (DD,17,salesdate) from salestable
select DATEDIFF (mm,salesdate,'1998-12-12') from salestable
select GETDATE()

--STRING
select UPPER(name)from salestable
select REVERSE(sales_id) from salestable
select REPLACE ('sanjana','a','t')from salestable
select ASCII(name)from salestable
select CONCAT(name,sales_id)from salestable
select SOUNDEX(name)from salestable
select DIFFERENCE(Tutuorial_id,sales_id)from salestable
select SUBSTRING(name,2,5)from salestable
--select LTRIM(name)from salestable
select UNICODE(salesdate)from salestable
