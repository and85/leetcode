package com.company;
import java.util.*;

public class Main {


    public static void main(String[] args) {
         KthLargest obj = new KthLargest(3, new int[]{ 4, 5, 8, 2 });
         obj.add(3);

    }

    static class KthLargest {

        PriorityQueue<Integer> minHeap = new PriorityQueue<>();
        final int k;

        public KthLargest(int k, int[] nums) {
            this.k = k;
            for (int i = 0; i < nums.length; i++)
                add(nums[i]);
        }

        public int add(int val) {
            // always keep exactly k largest elements in the heap,
            // remove the smallest element when heap size is too big
            // top element of the minHeap will be the kth largest element
            minHeap.add(val);
            if (minHeap.size() > this.k) {
                minHeap.poll();
            }

            return minHeap.peek();
        }
    }
}
