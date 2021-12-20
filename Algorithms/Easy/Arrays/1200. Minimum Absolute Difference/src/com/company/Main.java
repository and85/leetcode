package com.company;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Main {

    public static void main(String[] args) {
	    Solution s = new Solution();
	    s.minimumAbsDifference(new int[] {4, 2, 1, 3});
    }

    static class Solution {
        public List<List<Integer>> minimumAbsDifference(int[] arr) {

            List<List<Integer>> result = new ArrayList<List<Integer>>();
            int dif, minDif = Integer.MAX_VALUE;

            Arrays.sort(arr);

            for (int i = 1; i < arr.length; i++) {
                dif = arr[i] - arr[i - 1];
                if (dif < minDif) {
                    result.clear();
                    minDif = dif;
                    AddResult(new ArrayList<Integer>(List.of(arr[i - 1], arr[i])), result);
                }
                else if (dif == minDif) {
                    AddResult(new ArrayList<Integer>(List.of(arr[i - 1], arr[i])), result);
                }
            }

            return result;
        }

        private void AddResult(ArrayList<Integer> list1, List<List<Integer>> result) {
            List<Integer> list = list1;
            result.add(list);
        }
    }
}
