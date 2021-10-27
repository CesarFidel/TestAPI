CREATE DATABASE testAPI;

CREATE TABLE Post (
    UserId int  NOT NULL ,
	
    Id int NOT NULL IDENTITY(1,1) ,
    Title varchar(255),
    Boby varchar(255),
    PRIMARY KEY (UserId)
);

INSERT INTO Post (UserId,Title,Boby) VALUES (1,'sunt aut facere repellat provident occaecati excepturi optio reprehenderit','quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto');

INSERT INTO Post (UserId,Title,Boby) VALUES (1,'qui est esse','est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla');

INSERT INTO Post (UserId,Title,Boby) VALUES (2,'et ea vero quia laudantium autem','delectus reiciendis molestiae occaecati non minima eveniet qui voluptatibus\naccusamus in eum beatae sit\nvel qui neque voluptates ut commodi qui incidunt\nut animi commodi');


DROP TABLE Post