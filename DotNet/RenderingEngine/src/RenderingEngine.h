// �ȉ��� ifdef �u���b�N�� DLL ����̃G�N�X�|�[�g��e�Ղɂ���}�N�����쐬���邽�߂� 
// ��ʓI�ȕ��@�ł��B���� DLL ���̂��ׂẴt�@�C���́A�R�}���h ���C���Œ�`���ꂽ RENDERINGENGINE_EXPORTS
// �V���{�����g�p���ăR���p�C������܂��B���̃V���{���́A���� DLL ���g�p����v���W�F�N�g�ł͒�`�ł��܂���B
// �\�[�X�t�@�C�������̃t�@�C�����܂�ł��鑼�̃v���W�F�N�g�́A 
// RENDERINGENGINE_API �֐��� DLL ����C���|�[�g���ꂽ�ƌ��Ȃ��̂ɑ΂��A���� DLL �́A���̃}�N���Œ�`���ꂽ
// �V���{�����G�N�X�|�[�g���ꂽ�ƌ��Ȃ��܂��B
#ifdef RENDERINGENGINE_EXPORTS
#define RENDERINGENGINE_API __declspec(dllexport)
#else
#define RENDERINGENGINE_API __declspec(dllimport)
#endif

// ���̃N���X�� RenderingEngine.dll ����G�N�X�|�[�g����܂����B
class RENDERINGENGINE_API CRenderingEngine {
public:
	CRenderingEngine(void);
	// TODO: ���\�b�h�������ɒǉ����Ă��������B
};

extern RENDERINGENGINE_API int nRenderingEngine;

RENDERINGENGINE_API int fnRenderingEngine(void);
