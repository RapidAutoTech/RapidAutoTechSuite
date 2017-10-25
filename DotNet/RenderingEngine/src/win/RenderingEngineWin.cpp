// RenderingEngine.cpp : DLL アプリケーション用にエクスポートされる関数を定義します。
//

#include "stdafx.h"
#include "RenderingEngine.h"


// これは、エクスポートされた変数の例です。
RENDERINGENGINE_API int nRenderingEngine=0;

// これは、エクスポートされた関数の例です。
RENDERINGENGINE_API int fnRenderingEngine(void)
{
    return 42;
}

// これは、エクスポートされたクラスのコンストラクターです。
// クラス定義に関しては RenderingEngine.h を参照してください。
CRenderingEngine::CRenderingEngine()
{
    return;
}
