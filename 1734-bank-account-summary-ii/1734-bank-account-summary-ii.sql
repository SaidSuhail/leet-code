# Write your MySQL query statement below
select name,sum(amount) As balance from users left join transactions using(account) group by account having balance>10000