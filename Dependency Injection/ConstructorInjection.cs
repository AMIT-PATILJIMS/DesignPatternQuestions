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