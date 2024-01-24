# コンパイラ オプション

プロジェクトファイル（ `.csproj` ファイル）では、いくつかの特定のビルドおよび発行関連のオプションが利用できます。これらのオプションは、プロジェクトのビルド設定や発行方法をカスタマイズするために使用されます。指定されたオプションについての説明は以下の通りです：

## UseWPF:
このオプションは、プロジェクトが `Windows Presentation Foundation (WPF)` を使用するかどうかを指定します。true に設定すると、WPF関連の参照とビルド設定がプロジェクトに追加されます。

## IsShippingPackage:
このプロパティは、プロジェクトが「出荷」用パッケージであるかどうかを指定します。通常、`CI/CD` パイプラインなどでパッケージの種類を区別するために使用されます。

## PublishSingleFile:
アプリケーションを単一の実行ファイルとして発行するかどうかを指定します。`true` に設定すると、すべての依存関係が一つの実行可能ファイルに組み込まれます。

## SelfContained:
自己完結型のアプリケーションを発行するかどうかを指定します。`true` に設定すると、.NETランタイムもアプリケーションと一緒にバンドルされ、ターゲットシステムに.NETがインストールされていない場合でもアプリケーションを実行できます。

## RuntimeIdentifier (または RuntimeIdentifiers):
アプリケーションが対象とする特定のランタイムプラットフォームを指定します（例：`win-x64`、`linux-x64` など）。自己完結型の発行や、特定のOS向けのビルドに使用されます。

## EnableCompressionInSingleFile:
単一ファイルアプリケーションで圧縮を有効にするかどうかを指定します。これにより、発行された単一ファイルのサイズが小さくなりますが、初回起動時のパフォーマンスに影響する可能性があります。

## PublishTrimmed:
アプリケーションを発行する際に、未使用のコードをトリミング（削除）するかどうかを指定します。これにより、アプリケーションのサイズを小さくすることができます。

## TrimMode:
コードのトリミング方法を指定します。例えば、`link` はリンク時トリミングを意味し、アプリケーションのサイズを減らすために、未使用のアセンブリやメンバーを除去します。
