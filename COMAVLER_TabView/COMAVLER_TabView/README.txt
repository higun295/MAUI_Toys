# 개발 순서

0. 각 모양의 탭 구성
	- TabHost가 각 TabItem들을 품는다.
	- MaterialUnderlinedTabItem
	- SegmentedTabItem
	- UnderliendTabItem

1. ViewSwitcher(실제 View가 나타나는 공간)
	- DelayedView
	- LazyView
	- 여러가지 View의 형식이 사용됨
2. TabHostView(View를 전환하는 화면이 있는 공간)
3. BottomTabItem