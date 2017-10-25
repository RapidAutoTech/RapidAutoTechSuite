#pragma once

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
