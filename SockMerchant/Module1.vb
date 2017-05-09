Module Module1
    Sub Main()
		dim n As Int16 = Convert.ToInt32(Console.ReadLine())
        dim cTemp() as  String= Console.ReadLine().Split(" ")
		Dim c(cTemp.Length) As Int16
	    For i As Integer = 0 To cTemp.Length-1
		    c(i)=Convert.ToInt16(cTemp(i))
	    Next
		Dim sum As Int16=0
		Dim result As List(Of Int16)  =c.Distinct().ToList()
	    For i As Integer = 0 To result.Count-1
		    Dim tmp=result(i)
			Dim res=(From t In c Where t.Equals(tmp) Select t).Count()
		    If res>1  Then	
				If Math.Floor(res/2)<>Math.Ceiling(res/2) Then
					res=res-1
			    End If
				sum+=res/2
		    End If
	    Next
		Console.WriteLine(sum)
		Console.ReadLine()
    End Sub
End Module
