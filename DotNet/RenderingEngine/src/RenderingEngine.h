// 以下の ifdef ブロックは DLL からのエクスポートを容易にするマクロを作成するための 
// 一般的な方法です。この DLL 内のすべてのファイルは、コマンド ラインで定義された RENDERINGENGINE_EXPORTS
// シンボルを使用してコンパイルされます。このシンボルは、この DLL を使用するプロジェクトでは定義できません。
// ソースファイルがこのファイルを含んでいる他のプロジェクトは、 
// RENDERINGENGINE_API 関数を DLL からインポートされたと見なすのに対し、この DLL は、このマクロで定義された
// シンボルをエクスポートされたと見なします。
#ifdef RENDERINGENGINE_EXPORTS
#define RENDERINGENGINE_API __declspec(dllexport)
#else
#define RENDERINGENGINE_API __declspec(dllimport)
#endif

// このクラスは RenderingEngine.dll からエクスポートされました。
class RENDERINGENGINE_API CRenderingEngine {
public:
	CRenderingEngine(void);
	// TODO: メソッドをここに追加してください。
};

extern RENDERINGENGINE_API int nRenderingEngine;

RENDERINGENGINE_API int fnRenderingEngine(void);
