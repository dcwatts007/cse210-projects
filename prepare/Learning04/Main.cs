var mathAssignment = new Math();
var writing=new Writing();
mathAssignment.StudentName="Roberto Rodriguez";
mathAssignment.Topic="Fractions";
mathAssignment.TextbookSection="Section 7.3";
mathAssignment.Problems="Problems 8-9";
writing.StudentName="Mary Walters";
writing.Topic="European History";
writing.Title="The Causes of World War II by Mary Waters";
Console.WriteLine(mathAssignment.GetSummary()+"\n"+mathAssignment.GetHomeworkList()+"\n\n"+writing.GetSummary()+"\n"+writing.GetWritingInformation());