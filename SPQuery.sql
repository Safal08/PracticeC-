  Create procedure spAddStudent          
(          
    @Name VARCHAR(50),      
    @Address VARCHAR(50),
	@Faculty VARCHAR(50)
)          
as           
Begin           
   Insert into Students (Name,Address, Faculty)  
  Values 
(@Name,
@Address,
@Faculty)        
End




Create procedure spUpdateStudent            
(            
    @Id INTEGER ,          
    @Name VARCHAR(50),      
    @Address VARCHAR(50),
	@Faculty VARCHAR(50)         
)            
as            
begin            
   UPDATE Students SET Name = @Name, Address=@Address ,Faculty = @Faculty Where Id=@Id;            
End

Create procedure spDeleteStudent           
(            
   @Id int            
)            
as             
begin            
   Delete from Students where Id=@Id            
End


Create procedure spGetAllStudent        
as        
Begin        
    select *        
    from Students     
    order by Id   
End  