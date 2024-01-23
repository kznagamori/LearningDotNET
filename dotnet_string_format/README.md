# 各型のstring formatの組み合わせ

C#での各型の `string format` の組み合わせ例をいくつか紹介します。これらの例は、整数型、浮動小数点型、日付型など、様々なデータ型に適用される様々なフォーマットオプションを示しています。

## 1. 整数型のフォーマット
- 進数表示: 10進数、16進数、8進数
- 0パディング: 数値の先頭に0を追加
- 桁数制限: 指定した桁数で表示
- 右詰め、左詰め
```csharp
int number = 123;
string decimalFormat = $"{number:D5}"; // 00123 (5桁の10進数、0パディング)
string hexFormat = $"{number:X}";      // 7B (16進数)
string octalFormat = $"{Convert.ToString(number, 8)}"; // 173 (8進数)
```

## 2. 浮動小数点型のフォーマット
- 浮動小数点: 小数点以下の桁数指定
- 科学技術記法: 指数形式での表示
- 0パディング: 数値の先頭に0を追加
- 桁数制限
```csharp
double floatingNumber = 123.456789;
string floatFormat = $"{floatingNumber:F3}"; // 123.457 (小数点以下3桁)
string scientificFormat = $"{floatingNumber:E2}"; // 1.23E+002 (指数形式)
```

## 3. 日付型のフォーマット
- 日付フォーマット: 異なる日付と時刻の表示形式
- カスタムフォーマット: 日付と時刻のカスタマイズ
```csharp
DateTime now = DateTime.Now;
string dateFormat = $"{now:d}";   // MM/dd/yyyy
string timeFormat = $"{now:T}";   // HH:mm:ss
string customFormat = $"{now:yyyy年MM月dd日 HH時mm分ss秒}"; // 2024年01月19日 15時45分30秒
```

## 4. 文字列のフォーマット
- 文字数制限: 文字列の長さを制限
- 右詰め、左詰め
```csharp
string text = "Hello World";
string padRight = $"{text,-10}"; // "Hello World     " (右詰め、10文字分のスペース)
string padLeft = $"{text,10}";   // "     Hello World" (左詰め、10文字分のスペース)
string substring = $"{text.Substring(0, 5)}"; // "Hello" (最初の5文字)
```

これらのフォーマットは `.ToString()` メソッドや文字列補間を使用して適用でき、C#プログラムで数値や日付などのデータを表示する際に非常に役立ちます。
