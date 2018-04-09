--Nr 2
--SELECT * FROM Artist;

--Nr 3
--SELECT Name AS ArtistName 
--FROM Artist
--ORDER BY Name


--Nr 4
--SELECT TOP 10 ArtistId, Name 
--FROM Artist 
--order by Name

--Nr 5
--SELECT * 
--FROM Artist
--WHERE Name LIKE '%Academy%'

--Nr 6
--SELECT Album.Title
--FROM Album
--WHERE Album.Title LIKE '_ar%'

--Nr 7
--select Album.Title 
--from Album 
--where Title like '[aoueiy]%'

--Nr8
--SELECT Album.Title AS AlbumTitle, Artist.Name AS ArtistName
--FROM Album
--JOIN Artist ON Album.ArtistId = Artist.ArtistId
--ORDER BY ArtistName

--Nr10
--SELECT TOP 10 COUNT(Album.Title) AS NrOfAlbums, Artist.Name
--FROM Album
--JOIN Artist ON Album.ArtistId = Artist.ArtistId
--GROUP BY Artist.Name
--ORDER BY NrOfAlbums DESC

--Nr11
--SELECT DISTINCT Title, Genre.Name
--FROM Album
--INNER JOIN Track ON Album.AlbumId = Track.AlbumId
--INNER JOIN Genre ON Track.GenreId = Genre.GenreId
--WHERE Genre.Name IN ('Jazz', 'Blues')
--ORDER BY Title

--Nr 12

--Nr13
--SELECT COUNT (Genre.GenreId) AS NrOfTracks , Genre.Name
--FROM Genre
--INNER JOIN Track ON Track.GenreId = Genre.GenreId
--GROUP BY Genre.Name
--ORDER BY NrOfTracks DESC































