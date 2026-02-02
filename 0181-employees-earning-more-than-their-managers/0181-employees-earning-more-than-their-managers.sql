/* Write your T-SQL query statement below */
SELECT e.name as Employee from Employee e join Employee m on m.id = e.managerId where e.salary>m.salary