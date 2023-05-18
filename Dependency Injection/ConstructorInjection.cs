using System;

public interface Text
{
	void print();
}

public class format : Text
{
	public void print(){
	Console.WriteLine("here is text format");
	}
}

// constructor injection
public class ConstrutorInjection
{
	private readonly Text _text;
	
	public ConstrutorInjection(Text t1){
		this._text = t1;
	}
	public void print(){
		_text.print();
	}
}
					
public class Program
{
	public static void Main()
	{
		ConstrutorInjection cs = new ConstrutorInjection(new format());
		cs.print();
	}
}




//source
// https://www.c-sharpcorner.com/UploadFile/85ed7a/dependency-injection-in-C-Sharp/

// https://dotnettutorials.net/lesson/dependency-injection-design-pattern-csharp/#:~:text=The%20Dependency%20Injection%20Design%20Pattern%20in%20C%23%20is%20a%20process,the%20dependencies%20between%20the%20objects.