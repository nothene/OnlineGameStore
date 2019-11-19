
--delete from Purchase;
--delete from Games;

--delete from Library;

--dbcc checkident('Games', reseed, 0);

--Insert into Games (title, studio, genre, link, image_path, about) values
--	('Don''t Look Back', 'Terry Cavanagh', 'Platformer', 'https://terrycavanaghgames.com/dontlookback/', 'D:/Game_Pictures/dontlookback.jpg', 'Don''t Look Back is a platform game playable through Adobe Flash and designed by Terry Cavanagh. The game is a modern interpretation of the Orpheus and Eurydice Greek legend. 
--The game is a combination of two ideas; Cavanagh wished to create a "silly shooter" where the player''s actions were "redeemed" after being shown from a different perspective, he also wished to create a game where the gameplay acted as a metaphor of the player''s actions. 
--Critics praised the game''s addictiveness and presentation, but had different opinions over the game''s high difficulty level. '),
--	('Magic Cat Academy', 'Google', 'Adventure, Strategy', 'https://www.google.com/logos/2016/halloween16/halloween16.html?hl=en', 'D:/Game_Pictures/magiccatacademy.jpg', 'Magic Cat Academy is a browser game created as a Google Doodle and released on October 30, 2016.[1] The game, made playable in place of the logo on the Google website, was created in celebration of Halloween. 
--'), 
--	('Robot Unicorn Attack', 'Spiritonin Media Games', 'Platformer', 'http://www.adultswim.com/games/web/robot-unicorn-attack', 'D:/Game_Pictures/robotunicorn.jpg', 'Robot Unicorn Attack is an online "endless running" video game featured on the Adult Swim and Flashline Games website. The game was produced by American studio Spiritonin Media Games and was released in February 4, 2010. The game''s soundtrack is the 1994 song "Always," by the British band Erasure, in its "2009 mix" version. 
--With one million plays within the first week of its release,[1] Robot Unicorn Attack is one of the most popular and most played games featured on Adult Swim. As a result of its popularity, Adult Swim has made official merchandise for the game, and has released it on the App Store and Google Play. Adult Swim released three followups to Robot Unicorn Attack, subtitled Heavy Metal, Christmas Edition, and Evolution respectively.');

--select * from Games;

--insert into Library (user_id, game_id) values 
--	()

--update Library set times_visited = 1;

--select * from Library;

--select user_id from Account where username = 'nothene' And  password = 'password';

--update Library set times_visited = (times_visited + 1) where user_id = 1 and game_id = 1;

select * from Library;
