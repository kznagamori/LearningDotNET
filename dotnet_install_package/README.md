# パッケージをインストールして使用する

作成した .NET ツールを dotnet tool install コマンドでインストールするための詳細な手順は以下の通りです：

1. プロジェクトの作成:
    - 新しいコンソールアプリケーションプロジェクトを作成します。
    - `dotnet new console -n DotNetToolTest` コマンドを使用します。
2. プロジェクトファイルの編集:
    - `DotNetToolTest.csproj` ファイルを開きます。
    - `<OutputType>` を Exe に設定します。
    - `<PackAsTool>` を true に設定します。
    - `<ToolCommandName>` をツールのコマンド名に設定します。
    - `<PackageOutputPath>` に出力ディレクトリを設定します。

3. ツールのコード編集:
    - ツールとして動作させたい機能のコードを作成します。
4. ツールのビルドとパッケージング:
    - `dotnet pack` コマンドでツールをパッケージ化します。
5. ローカルパッケージのインストール:
    - ローカルで開発したツールをインストールするには、`dotnet tool install --global --add-source <パッケージのディレクトリ> DotNetToolTest` コマンドを使用します。

これにより、ローカルから .NET ツールをインストールできます。