package com.company;

public class Main {

    public static void main(String[] args) {
	    Solution s = new Solution();

	    int bs[] = s.findBuildings(new int[] {4,3,2,1});

        for (int b: bs)
            System.out.print(b + " ");

        System.out.println();
    }
}
