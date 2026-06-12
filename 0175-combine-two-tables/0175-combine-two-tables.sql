/* Write your T-SQL query statement below */
select A.firstName,A.lastName,B.city,B.state from Person A Left join Address B on A.personId = B.personId