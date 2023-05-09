drop DATABASE if exists baseball;
create database baseball;
use baseball;
create table team 
(
    id int NOT NULL AUTO_INCREMENT,
    state_id varchar(50),
    name varchar(50),
    PRIMARY KEY (id)
) AUTO_INCREMENT=1;

create table state 
(
    id int NOT NULL AUTO_INCREMENT,
    name varchar(50),  
    abbrev varchar(2),
    PRIMARY KEY (id)    
) AUTO_INCREMENT=1;

create table player 
(
    id int NOT NULL AUTO_INCREMENT,
    team_id int,
    name varchar(50),  
    num int,
    PRIMARY KEY (id)    
) AUTO_INCREMENT=1;



insert state (name, abbrev) values 
('Georgia', 'GA'),
('Florida', 'FL'),
('New York', 'NY'),
('Pennsylvania', 'PA'),
('Washington, D.C.', 'DC') ;


insert team (name, state_id) values
('Atlanta Braves', 1),
('Miami Marlins', 2),
('New York Mets', 3),
('Philadelphia Phillies', 4),
('Washington Nationals', 5);


insert player (team_id, name, num) values
(1, 'Luke Jackson',77),
(1, 'Shane Greene',19),
(1, 'Mike Foltynewicz',26),
(1, 'Dallas Keuchel',60),
(1, 'Mark Melancon',36),
(1, 'Josh Tomlin',32),
(1, 'Sean Newcomb',15),
(1, 'Darren O''Day',56),
(1, 'Julio Teheran',49),
(1, 'Mike Soroka',40),
(1, 'Max Fried',54),
(1, 'Matthew Joyce',14),
(1, 'Nick Markakis',22),
(1, 'Brian McCann',16),
(1, 'Rafael Ortega',18),
(1, 'Ronald Acuna Jr.',13),
(1, 'Dansby Swanson',7),
(1, 'Ozzie Albies',1),
(1, 'Francisco Cervelli',45),
(1, 'Josh Donaldson',20),
(1, 'Adam Duvall',23),
(1, 'Tyler Flowers',25),
(1, 'Freddie Freeman',5),
(1, 'Billy Hamilton',9),
(1, 'Adeiny Hechavarria',24),
(1, 'Touki Toussaint',62),
(1, 'Patrick Weigel',72),
(1, 'Bryse Wilson',46),
(1, 'Kyle Wright',30),
(1, 'Anthony Swarzak',38),
(1, 'Jeremy Walker',63),
(1, 'Chad Sobotka',61),
(1, 'Chris Martin',51),
(1, 'Grant Dayton',75),
(1, 'Jerry Blevins',50),
(1, 'Huascar Ynoa',73),
(1, 'Austin Riley',27),
(1, 'John Ryan Murphy',55),
(1, 'Ender Inciarte',11),
(1, 'Johan Camargo',17),
(2, 'Sandy Alcantara',22),
(2, 'Elieser Hernandez',57),
(2, 'Jordan Yamamoto',50),
(2, 'Jordan Holloway',0),
(2, 'Kyle Keller',72),
(2, 'Tyler Kinley',39),
(2, 'Pablo Lopez',49),
(2, 'Brian Moran',63),
(2, 'Hector Noesi',48),
(2, 'Jose Quijada',74),
(2, 'Caleb Smith',31),
(2, 'Josh Smith',68),
(2, 'Ryne Stanek',35),
(2, 'Jose Urena',62),
(2, 'Jorge Guzman',0),
(2, 'Tayron Guerrero',56),
(2, 'Jeff Brigham',43),
(2, 'Jarlin Garcia',66),
(2, 'Robert Dugger',64),
(2, 'Austin Brice',37),
(2, 'Wei-Yin Chen',20),
(2, 'Adam Conley',61),
(2, 'Miguel Rojas',19),
(2, 'Jesus Sanchez',0),
(2, 'Magneuris Sierra',34),
(2, 'Curtis Granderson',21),
(2, 'Jon Berti',55),
(2, 'Jorge Alfaro',38),
(2, 'Neil Walker',18),
(2, 'Harold Ramirez',47),
(2, 'Lewis Brinson',9),
(2, 'Monte Harrison',0),
(2, 'Tyler Heineman',51),
(2, 'Isan Diaz',1),
(2, 'Austin Dean',44),
(2, 'Garrett Cooper',26),
(2, 'Starlin Castro',13),
(2, 'Martin Prado',14),
(2, 'Cesar Puello',46),
(2, 'Bryan Holaday',28),
(3, 'Daniel Zamora',73),
(3, 'Franklyn Kilome',66),
(3, 'Walker Lockett',61),
(3, 'Seth Lugo',67),
(3, 'Steven Matz',32),
(3, 'Chris Mazza',74),
(3, 'Stephen Nogosek',72),
(3, 'Corey Oswalt',55),
(3, 'Paul Sewald',51),
(3, 'Marcus Stroman',7),
(3, 'Noah Syndergaard',34),
(3, 'Zack Wheeler',45),
(3, 'Justin Wilson',38),
(3, 'Donnie Hart',68),
(3, 'Robert Gsellman',65),
(3, 'Jeurys Familia',27),
(3, 'Jacob deGrom',48),
(3, 'Edwin Diaz',39),
(3, 'Chris Flexen',64),
(3, 'Brad Brach',29),
(3, 'Tyler Bashlor',49),
(3, 'Drew Gagnon',47),
(3, 'Luis Avilan',43),
(3, 'Rene Rivera',44),
(3, 'Amed Rosario',1),
(3, 'Michael Conforto',30),
(3, 'Dominic Smith',22),
(3, 'Luis Guillorme',13),
(3, 'Robinson Cano',24),
(3, 'Wilson Ramos',40),
(3, 'Joe Panik',2),
(3, 'Sam Haggerty',19),
(3, 'Todd Frazier',21),
(3, 'Juan Lagares',12),
(3, 'Jed Lowrie',4),
(3, 'Tomas Nido',3),
(3, 'Brandon Nimmo',9),
(3, 'Rajai Davis',18),
(3, 'J.D. Davis',28),
(3, 'Pete Alonso',20),
(4, 'Jose Alvarez',52),
(4, 'Edubray Ramos',61),
(4, 'Jared Hughes',25),
(4, 'Cole Irvin',47),
(4, 'Nick Pivetta',43),
(4, 'Blake Parker',53),
(4, 'Mike Morin',28),
(4, 'Aaron Nola',27),
(4, 'Hector Neris',50),
(4, 'Juan Nicasio',12),
(4, 'J.D. Hammer',65),
(4, 'Vince Velasquez',21),
(4, 'Drew Smyly',18),
(4, 'Nick Vincent',29),
(4, 'Ranger Suarez',55),
(4, 'Edgar Garcia',66),
(4, 'Jason Vargas',44),
(4, 'Austin Davis',54),
(4, 'Enyel De Los Santos',51),
(4, 'Zach Eflin',56),
(4, 'Jose Pirela',67),
(4, 'Jean Segura',2),
(4, 'Roman Quinn',24),
(4, 'J.T. Realmuto',10),
(4, 'Sean Rodriguez',13),
(4, 'Logan Morrison',8),
(4, 'Jay Bruce',23),
(4, 'Maikel Franco',7),
(4, 'Arquimedes Gamboa',70),
(4, 'Phil Gosselin',9),
(4, 'Deivy Grullon',73),
(4, 'Bryce Harper',3),
(4, 'Adam Haseley',40),
(4, 'Cesar Hernandez',16),
(4, 'Rhys Hoskins',17),
(4, 'Scott Kingery',4),
(4, 'Andrew Knapp',15),
(4, 'Brad Miller',33),
(4, 'Nick Williams',5),
(4, 'Adonis Medina',77),
(5, 'Stephen Strasburg',37),
(5, 'Max Scherzer',31),
(5, 'Fernando Rodney',56),
(5, 'Hunter Strickland',60),
(5, 'Sean Doolittle',63),
(5, 'Wander Suero',51),
(5, 'Patrick Corbin',46),
(5, 'Daniel Hudson',44),
(5, 'Tanner Rainey',21),
(5, 'Austin Voth',50),
(5, 'Anibal Sanchez',19),
(5, 'Anthony Rendon',6),
(5, 'Victor Robles',16),
(5, 'Juan Soto',22),
(5, 'Matt Adams',15),
(5, 'Kurt Suzuki',28),
(5, 'Michael A. Taylor',3),
(5, 'Trea Turner',7),
(5, 'Gerardo Parra',88),
(5, 'Ryan Zimmerman',11),
(5, 'Adam Eaton',2),
(5, 'Brian Dozier',9),
(5, 'Howie Kendrick',47),
(5, 'Asdrubal Cabrera',13),
(5, 'Yan Gomes',10),
(5, 'James Bourque',0),
(5, 'Aaron Barrett',32),
(5, 'Roenis Elias',29),
(5, 'Erick Fedde',23),
(5, 'Joe Ross',41),
(5, 'Javy Guerra',48),
(5, 'Jeremy Hellickson',58),
(5, 'Kyle McGowin',61),
(5, 'Adrian Sanchez',5),
(5, 'Tres Barrera',73),
(5, 'Carter Kieboom',8),
(5, 'Raudy Read',65),
(5, 'Wilmer Difo',1),
(5, 'Andrew Stevenson',17),
(5, 'Jake Noll',18);


/* QUERY 1 */
/* using JOIN .. Show the player name, uniform number and team name order by team name */
  select t.name, p.name, p.num 
  from team t 
  join player p on (t.id = p.team_id)
  order by t.name ;

/* using WHERE .. do the same query as above */
  select t.name, p.name, p.num 
  from team t, player p 
  where t.id = p.team_id
  order by t.name ;


/* QUERY 2 */
/* using JOIN .. Add the state name and abbreviation to QUERY 1  */
  select t.name, p.name, p.num, s.name, s.abbrev 
  from team t 
  join state s on (t.state_id = s.id)
  join player p on (t.id = p.team_id)
  order by t.name ;

/* using WHERE .. do the same query as above  */
  select t.name, p.name, p.num, s.name, s.abbrev 
  from team t, state s, player p
  where 
      t.state_id = s.id
  and t.id = p.team_id
  order by t.name ;


/* for the remaining queries, we will stick to using JOIN to link tables */

/* QUERY 3 */
/* Make the display of Query 2 make a little more sense  */
  select t.name as 'Team Name'
      , p.name as 'Player Name'
      , p.num as 'Uniform Num'
      , s.name as 'State Name'
      , s.abbrev as 'State Abbreviation' 
  from team t 
  join state s on (t.state_id = s.id)
  join player p on (t.id = p.team_id)
  order by t.name ;


/* QUERY 4 */
/* Get the players whose uniform number = their team's primary key  */
  select t.name, p.name, p.num 
  from team t 
  join player p on (t.id = p.team_id and t.id = p.num)
  order by t.name ;


/* QUERY 5 */
/* Get the players who have the same uniform number */
  select p1.id as 'Player1 ID', p1.name as 'Player 1 Name', p2.id as 'Player2 ID', p2.name as 'Player 2 Name', p1.num as 'Uniform Num' 
  from player p1 
  join player p2 on (p1.id <> p2.id and p1.num = p2.num)
  order by p1.num ;


/* QUERY 6 */
/* Query 5 has a problem: it is listing every match twice: for example ..
+------------+---------------------+------------+---------------------+-------------+
| Player1 ID | Player 1 Name       | Player2 ID | Player 2 Name       | Uniform Num |
+------------+---------------------+------------+---------------------+-------------+
|         44 | Jordan Holloway     |         64 | Jesus Sanchez       |           0 |
...
|         64 | Jesus Sanchez       |         44 | Jordan Holloway     |           0 |
...

Fix this by requiring Player 1's primary key to always be less than Player 2's primary key.
In the example above, that would eliminate the row where Jordon Holloway is Player 2 
because 44<64

*/

  select p1.id as 'Player1 ID', p1.name as 'Player 1 Name', p2.id as 'Player2 ID', p2.name as 'Player 2 Name', p1.num as 'Uniform Num' 
  from player p1 
  join player p2 on (p1.id < p2.id and p1.num = p2.num)
  order by p1.num ;
  
/* QUERY 7 */
/* Include player1 and player 2 team names into Query 6 and do not show the player primary keys */
  select p1.name as 'Player 1 Name'
      , t1.name as 'Player 1 Team'
      , p2.name as 'Player 2 Name'
      , t2.name as 'Player 2 Team'
      , p1.num as 'Uniform Num' 
  from player p1 
  join player p2 on (p1.id < p2.id and p1.num = p2.num)
  join team t1 on t1.id = p1.team_id
  join team t2 on t2.id = p2.team_id
  order by p1.num ;
  

/* QUERY 8 */
/* Get player counts per team */
  select count(*) as 'Player Count', t.name as 'Team Name'
  from team t 
  join player p on (t.id = p.team_id)
  group by t.name
  order by t.name ;

/* QUERY 9 */
/* Get player counts per team where the player uniform number is <= 10 */
  select count(*) as 'Player Count', t.name as 'Team Name'
  from team t 
  join player p on (t.id = p.team_id)
  where p.num <= 10
  group by t.name
  order by t.name ;

/* QUERY 10 */
/* Get player counts per team where the player uniform number is <= 10 and the count is >= 7 */
  select count(*) as 'Player Count', t.name as 'Team Name'
  from team t 
  join player p on (t.id = p.team_id)
  where p.num <= 10
  group by t.name
  having count(*) >= 7
  order by t.name ;

