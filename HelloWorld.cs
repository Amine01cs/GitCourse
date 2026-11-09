using system;

// Learning Delegates & Lambda Expressions: 
namespace HelloWorld{
	public delegate bool del3(int a,int b);
	internal class program
	{
		static void Main(){
			List<int> L = new List<int>{10,3,5,47,23,7,1,100};

			List<int> FilterdList = GetFilterdValue(L,10,(a,b)=>a<b); 

			foreach(int item in FilterdList){
				System.Console.WriteLine(item);
			}
		}
		static List<int> GetFilterdValue(List<int>L1,int x,del3 Opera){
			List<int> FilterdList = new List<int>();

			foreach(int item in L1){
				if(Opera(item,x)){
					FilterdList.Add(item);
				}
			}
			return FilterdList;
		}
	}
}