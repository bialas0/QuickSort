# QuickSort
A simple quicksort algorithm with horizontal bar animations in a C# console. 
#
![quicksort-gif](https://user-images.githubusercontent.com/118835576/223756524-e30dfd9f-7639-48f2-8505-89373df219ab.gif)
#
# How it works...
### 1. Given an unsorted list of 7 unsigned intigers, quicksort will select the 1st element in the list. 
## [ 56, 77, 21, 9, 58, 54, 28 ] -> (56)
### 2. The algorithm compares the pivot to each item in the list, and place it to the left if smaller, or right if larger than the interated element. 
## [21, 9, 54, 28] - (56) - [77, 58] 
### 3. This process repeats until every subset contains no more than 2 items, esentially splitting each item into pairs. 
## [21, 9] - [54, 28] - [77, 58]
### 4. Each pair's items are now compared to each other, sorting them if the left value is larger than the right. 
## [9, 21] - [28, 54] - [58, 77]
### 5. The final operation merges each subset into the finally sorted list. 
## [9, 21, 28, 54, 58, 77]
