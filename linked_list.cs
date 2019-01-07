// Singily linked list basic class

class ListNode
{
    // two properties, data and reference to next node
    int data;
    ListNode next = null;
    // constructor for new node
    public ListNode(int d)
    {
        data = d;
    }
    // add new node to end of list
    public void addToTail(int d)
    {
        ListNode end = new ListNode(d);
        ListNode n = this;
        // loop through to get to the end of list
        while (n.next != null)
        {
            n = n.next;
        }
        n.next = end;
    }
    // deleting node requires you to pass node head so full linked list can be searched
    public ListNode deleteNode(ListNode head, int d)
    {
        ListNode n = head;
        // if node to delete is node head, return next as the new head
        if (n.data == d)
        {
            return head.next;
        }
        // loop through each node in list
        while (n.next != null)
        {
            if (n.next.data == d)
            {
                n.next = n.next.next;
                return head; // head doesn't change
            }
            n = n.next;
        }
        // if node data not found, return original list
        return head;
    }
}