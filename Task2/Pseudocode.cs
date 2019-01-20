//setup
double height1 = 0.0;
double width1 = 0.0;

double height2 = 0.0;
double width2 = 0.0;

double area1 = 0.0;
double area2 = 0.0;

//input
input "Please enter height of first rectangle."
get height1

"Please enter width of first rectangle."
get width1

"Please enter height of second rectangle."
get height2

"Please enter width of second rectangle."
get width2



//proccess
area1 = height1* width1;
area2 = height2* width2;

//output
if area1 > area2
"First rectangle with area " +area1 + 
" unit sq is larger than the area of the second rectangle with area "
 + area2 + " square units"
 if else area1 == area2
 "Both rectangles have "+ area1 +"  and are same size" 
 else
	 "Second rectangle with area " +area2 + " 
	unit sq is larger than the area of the first rectangle with area
	"  area1 +" square units"