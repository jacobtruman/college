#!/usr/bin/perl -w

# ----------------------------
# Example #1

my  $x1 = 3;

sub exp1_sub1 {
    my  $x1 = 5;
    $x1 += 2;
    exp1_sub2();
}

sub exp1_sub2 {
    $x1 += 2;
    print "x1= $x1 \n";
}

print "-----------\nExample #1:\n";
exp1_sub1();
exp1_sub2();


# ----------------------------
# Example #2

local  $x2 = 3;

sub exp2_sub1 {
    local  $x2 = 5;
    $x2 += 2;
    exp2_sub2();
}

sub exp2_sub2 {
    $x2 += 2;
    print "x2= $x2 \n";
}

print "\n-----------\nExample #2:\n";

exp2_sub1();
exp2_sub2();

