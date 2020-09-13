Question: A start-up owner is looking to meet new investors to get some funds for his company. Each investor has a tight schedule that the owner has to respect. Given the schedules of the days investors are available, determine how many meetings the owner can schedule. Note that the owner can only have one meeting per day.The schedules consists of two integer arrays, firstDay and lastDay. Each element in the array firstDay represents the first day an investor is available, and each element in lastDay represents the last day an investor is available, both inclusive.


STDIN     Function
------    --------
5         firstDay[] size n = 5
1    →    firstDay = [1, 2, 1, 2, 2]
2
1
2
2
5    →    lastDay[] size n = 5
3    →    lastDay = [3, 2, 1, 3, 3]

Sample Output : 3


Another Sample Data: 
    firstDayCount = 5
    firstDay = [1,2,1,2,2]
    lastDayCount = 5
    lastDay = [1,2,3,5,3]



    Result : 4