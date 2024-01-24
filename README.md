# LearningDotNET
.NET学習用レポジトリ

## .NETとは
.NET（発音は「ドットネット」と読みます）は、主にマイクロソフトによって開発されたソフトウェアフレームワークです。このフレームワークは、アプリケーション開発のための総合的なプラットフォームを提供し、特にC#（シーシャープ）という言語が広く使用されています。以下に.NETとC#の主要な特徴を説明します：

### .NET の特徴
1. クロスプラットフォーム：.NETの導入により、.NETはWindowsだけでなくLinuxやmacOSなどのプラットフォームでも動作します。

2. 言語の多様性：C#、F#、Visual Basicなど、複数のプログラミング言語がサポートされています。

3. 統合開発環境：Visual Studioなどの強力な開発環境を利用して、開発の効率を高めることができます。

4. 豊富なライブラリ：.NETフレームワークには、データアクセス、ネットワーキング、グラフィックスインターフェイスなどのための広範なライブラリが含まれています。

5. ASP.NET：ウェブアプリケーションとサービスの開発を支援するための強力なフレームワーク。

### C# の特徴
1. オブジェクト指向言語：C#はオブジェクト指向プログラミングを完全にサポートしています。

2. 静的型付け：C#は静的型付け言語であり、型安全性を重視しています。

3. シンプルで読みやすい構文：C#はC++やJavaに似た構文を持ちつつ、より簡潔で読みやすいデザインになっています。

4. リッチな標準ライブラリ：C#は.NETフレームワークのライブラリを利用することで、多様な開発ニーズに応えます。

5. モダンなプログラミング機能：非同期プログラミング、LINQ（統合言語クエリ）、タプルなどのモダンな機能をサポート。

.NETとC#は、デスクトップアプリケーション、ウェブサービス、クラウドベースのアプリケーション、ゲーム開発（特にUnityエンジンでの使用）、および企業向けアプリケーションの開発に広く使用されています。その豊富な機能と強力な開発ツールにより、初心者からプロの開発者まで幅広く支持されています。


### 推しポイント
- 学習コストが低い。
- 使用可能なパッケージが多く存在するので、ツールを作成しやすい。
- ネットや本での参考文献が多い
- ChatGPTで質問すると、かなり正解に近いコードを取得できる。

### いまいち、ダメなポイント
- 実行ファイルサイズが大きい（60MB～）
- エコシステムのパッケージのインストールでgithubなどのレポジトリが使用できない。
- GUIクロスプラットフォームアプリは作れるけど微妙

## 基礎
- [プロジェクト作成からビルドまでの手順](./dotnet_start_project/README.md)
- [外部パッケージを使用したプログラムを作成する手順](./dotnet_use_package/README.md)
- [複数ファイルを使用する](./dotnet_multi_file/README.md)
- [複数ファイルを機能ごとにパッケージを分けて使用する](./dotnet_multi_pack_file/README.md)
- [ファイル内グローバル変数と関数、ファイル外グローバル変数と関数](./dotnet_global_local_scope/README.md)
- [クラスを使う](./dotnet_class_methods/README.md)
- [パブリックなクラスのメンバ、メソッドを定義とプライベートなクラスのメンバ、メソッドを定義する](./dotnet_public_private/README.md)
- [クラスの継承を実現する](./dotnet_inherit_class/README.md)
- [クラスのインタフェースを使用したポリモーフィズムの実現](./dotnet_poly_class/README.md)
- [クラスのプロパティを定義、使用](./dotnet_class_property/README.md)
- [一般的なエラー処理](./dotnet_error_handling/README.md)
- [各型のstring formatの組み合わせ](./dotnet_string_format/README.md)
- [ジェネリック機能](./dotnet_generics_example/README.md)
- [ラムダ式](./dotnet_lambda_example/README.md)
- [LINQ機能](./dotnet_linq_example/README.md)

## アルゴリズムとデータ構造
- [リンクドリスト構造](./dotnet_linked_list/README.md)
- [リングバッファ構造](./dotnet_ring_buffer/README.md)
- [キュー構造](./dotnet_data_queue/README.md)
- [スタック構造](./dotnet_data_stack/README.md)
- [二分木構造](./dotnet_binary_tree/README.md)
- [平衡二分木構造](./dotnet_balanced_tree/README.md)
- [ハッシュテーブル](./dotnet_hash_table/README.md)
- [クイックソート](./dotnet_quick_sort/README.md)
- [再帰を使用しないシェルソート](./dotnet_non_recursive_shell_sort/README.md)

## 応用
- [リンクドリスト](./dotnet_list_package/README.md)
- [キュー](./dotnet_queue_package/README.md)
- [スタック](./dotnet_stack_package/README.md)
- [平衡二分木](./dotnet_balanced_tree_package/README.md)
- [ハッシュテーブル](./dotnet_hash_table_package/README.md)
- [ソート](./dotnet_sort_package/README.md)
- [スレッド](./dotnet_threading_example/README.md)
- [Async/Await](./dotnet_async_await_example/README.md)
- [排他処理](./dotnet_mutex_example/README.md)
- [メッセージボックス](./dotnet_message_box_example/README.md)

## エコシステム
- [パッケージをインストールして使用する](./dotnet_install_package/README.md)



