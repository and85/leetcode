package com.company;

import java.util.ArrayList;
import java.util.List;

public class Main {

    public static void main(String[] args) {
	    var s = new Solution();
	    s.largeGroupPositions("yyy");
    }

    public static class Solution {
        public List<List<Integer>> largeGroupPositions(String s) {
            var result = new ArrayList<List<Integer>>();

            if (s == null || s.isEmpty() || s.trim().isEmpty())
                return result;

            int size  = 1, start = -1, end = -1;
            for (int i = 1; i < s.length(); i++) {
                if (s.charAt(i) == s.charAt(i - 1)) {
                    end = i;
                    if (++size == 3) {
                        start = i - 2;
                    }
                }
                else {
                    if (size >= 3)
                    {
                        PopulateResult(result, start, end);
                    }

                    size = 1;
                }


            }

            if (size >= 3)
                PopulateResult(result, start, end);

            return result;
        }

        private void PopulateResult(ArrayList<List<Integer>> result, int start, int end) {
            var list = new ArrayList<Integer>();
            list.add(start);
            list.add(end);
            result.add(list);
        }
    }
}
