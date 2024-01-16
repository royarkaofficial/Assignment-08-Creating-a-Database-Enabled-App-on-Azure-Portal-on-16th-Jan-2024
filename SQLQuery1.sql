select * from Player
insert into Player values (6, 'Sameer Rizvi', 'All-Rounder', 'CSK')
insert into Player values (7, 'Hardik Pandaya', 'All-Rounder', 'MI')

create proc usp_iPlayer
@id int,
@name nvarchar(50),
@role nvarchar(50),
@team nvarchar(50)
as 
insert into Player values (@id, @name, @role, @team)
exec usp_iPlayer 11, 'Jasprit Bumrah', 'Bowler', 'MI'
execute usp_sPlayers