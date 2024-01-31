//MIS 3033
//Jan 31- Feb 1
//Camille Duryea
//113529005

//delegate: a key word to define a function type 
//class to define a new datatype

using f1;

Console.WriteLine("delegate");

Student stu1; //

bool CheckAge(Student stu)
{
    if (stu.age > 20)
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool CheckGrade(Student stu)//check grade is equal then or greater than 80
{
    if(stu.grade >= 80)
    {
        return true;
    }
    else
    {
        return false;
    }

}

FuntionType1 funType1Card;

funType1Card = CheckAge;
stu1 = new Student();
stu1.Name = "tom";
stu1.age = 20;
stu1.grade = 90;
stu1.weight = 128;

Console.WriteLine(funType1Card(stu1));

Console.ReadKey();


//define a delegate at the end of the code

delegate bool FuntionType1(Student stu); //we defined a function type

