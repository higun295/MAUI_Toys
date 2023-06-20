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





- Class에 ContentProperty라는 Attribute를 명시적으로 지정하니까 하위에 여러 개의 Control을 포함하는 부모 Control이 되었음(Mark-Up Extension)
- 