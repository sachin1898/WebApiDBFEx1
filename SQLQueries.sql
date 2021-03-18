drop database PlayersDb
create database PlayersDb
use PlayersDb
create table Players(
PId int primary key,
PName nvarchar(50) not null,
BattingAverage float,
BowlingAverage float,
PTeam nvarchar(20)
)
insert into Players values(1,'hardik pandya','45.2','5.2','india')
insert into Players values(2,'virat kohli','56.5','8.2','india')

select * from Players