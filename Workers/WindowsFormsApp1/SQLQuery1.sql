   --Определяем повторяющиеся значения в столбце
   SELECT Position, COUNT(*) AS CNT, avg(Salary) AS AVG_Salary
   FROM Workers
   GROUP BY Position;