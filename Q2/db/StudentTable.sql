CREATE TABLE Students(
StudentId INT NOT NULL PRIMARY KEY,
StudentName varchar(255),
StudentCity varchar(255),
Course INT FOREIGN KEY REFERENCES Courses(CourseId)
)