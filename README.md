
HOW TO RUN THE APPLICATION
--------------------------

 1. Download the zip file from github and extract it.

 2. Open the sln file and run it (It will list some of the added entry into database)
    I have configured database on godaddy server and have inserted some record into it.
	
	Connection string to be used in this case :-
	 <add name="IMDBContext" connectionString="Data Source=182.50.133.110;........"
	 
	Comment other connection string 
	
	               OR

 3. If you want to create database on your own and the start with zero record , no problem
    I have put my database script in folder name Database/IMDBScript.sql
    run the scrip but before that change the server name in connection string section of Web.config
	
	Connection string would be used in this case :- 
	
	(a) SQL authentication 
	"<add name="IMDBContext" connectionString="Data Source=INDIA3\SQLEXPRESS;Initial Catalog=SudarshanTest;Persist Security Info=True;User ID=sa;Password=su"
    change:-  1. Data source 2.User Id and 3. Password
	
	(b) Windows authentication 
	
	 <add name="IMDBContext" connectionString="Data Source=INDIA3\SQLEXPRESS;Initial Catalog=SudarshanTest;Integrated Security=True" providerName="Syste.."
	 
	 Change:-  1. Data Source


	 
SCREENSHOTS 
-----------
 I have taken screen shot of important windows and put in ScreenShot Folder in Root directory of 
 project , please have  a look. 
	 
MY APPROACH TO BUILD THIS APPLICATION
-------------------------------------


1. Firstly i wrote a SQL script to create tables 
    
    1. Actor
    2. Producer
    3. Movie
    4. ActorMovie (Link Table between Actor and Movie to store many to many application)

    I have configured primary key , foreign key and check constraint for tables here. 

2. After the SQL table I have wrote POCO to map the created table by SQL.

3. Then created IMDBContext class where i have listed the table and wrote Fluent API configuration for the classes to map the relationship.

4. Created a View Model named "MovieViewModel" to create , edit the records.

5. Added Movies Controller , that has following important method
  
	Index() - Default method that list down all the movies 
        Create() - We can add new Movies from  here 
                    Note - while adding new movie we can add new actors as well as new producer
        
        Edit () - We can Edit the Movies with existing details of the movie.

        Delete - We can delete the movies item from this action , it will delete the data from table as well as image file placed 
                 under folder Images/Movies
  
        Note - I have put comment inside these function that will help to understand it better.

6. Added two controllers ActorController and ProducerController those have methods
      AddNewActor()
      AddNewProducer()
      these methods are being called by JQuery.  

7. There are two methods which adds and removes record from ActorMovie tables
        AddSeletedActors() 
	RemoveDeselectedActors()


8.Constraint - 
   *SQL - check constraint on Year of Release in Movie Database 
   *Actors is required in   Edit Screen - (http://localhost:61653/Movies/Edit/3)
   *Producers is Required in Edit Screen - (http://localhost:61653/Movies/Edit/3)
   *Name , Year of Release are required while creating or editing the movie 
