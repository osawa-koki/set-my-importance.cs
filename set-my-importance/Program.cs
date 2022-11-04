using System.Diagnostics;

var priority_enum = Enum.GetValues(typeof(ProcessPriorityClass)).Cast<int>().ToList();
Process myself = Process.GetCurrentProcess();

while (true)
{
  Console.WriteLine("");
  Console.WriteLine("優先度を指定してください。");
  Console.WriteLine("");

  foreach (int importance in priority_enum)
  {
    Console.WriteLine("{0,15} -> {1}", (ProcessPriorityClass)importance, importance);
  }

  int level;
  if (int.TryParse(Console.ReadLine(), out level) && priority_enum.Contains(level))
  {
    Console.Clear();
    myself.PriorityClass = (ProcessPriorityClass)level;
    Console.WriteLine("");
    Console.WriteLine("優先度を変更しました。");
    Console.WriteLine($"現在 -> {(ProcessPriorityClass)level} ({level})");
  } else
  {
    Console.Clear();
    Console.WriteLine("正しい数値を入力してください。");
  }
}
