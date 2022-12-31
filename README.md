# set-my-importance

自分自身のプロセスの優先度を変更する学習用プロジェクト。  

## 説明

`Process.GetCurrentProcess()`で現在のプロセスを取得し、その`PriorityClass`プロパティに`ProcessPriorityClass`列挙型の値をセットするだけ。  

## 参考文献

- [公式ドキュメント](https://learn.microsoft.com/ja-jp/dotnet/api/system.diagnostics.processpriorityclass)
