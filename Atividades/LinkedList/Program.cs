
using System.Dynamic;
using LinkedList;

Page pageFirst = new Page() { Content = "atualmente...",};
Page pageSecond = new Page() { Content = "aplicação...",};
Page pageThird = new Page() { Content = "Muito de...",};
Page pageFourth = new Page() {Content ="Você sabia...", PageNumber = 4 };
Page pageFifth = new Page () {Content = "Enquanto...", PageNumber = 5 };
Page pageSixth = new Page () {Content = "Você poderia...", PageNumber = 6};
Page pageSeventh = new Page () {Content = "Era uma vez...", PageNumber =7};
//Page pageFifth = new Page () {
//    Content = "Enquanto...",
 //   PageNumber = 5
 //   };
 //   Page pageSixth = new Page () {
 //       Content = "Você poderia...",
 //       PageNumber = 6
//
LinkedList<Page> pages = new LinkedList<Page>();
pages.AddLast(pageSecond);
LinkedListNode<Page> nodepageFourth =
    pages.AddLast(pageFourth);
pages.AddLast(Page Sixth);
pages.AddFirst(pageFirst);
pages.AddBefore()