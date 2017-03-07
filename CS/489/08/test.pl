#!/usr/bin/perl -w

use strict;
my $i = 0;
 my $states = [ 'F', 'B' ];
 my $observations = [ 0, 1 ];
 my $start_probability = { 'F'=> 0.5, 'B'=> 0.5 };
 my $transition_probability = {
    'F' => {'F'=> 0.9, 'B'=> 0.1},
    'B' => {'F'=> 0.1, 'B'=> 0.9},
    };
 my $emission_probability = {
    'F' => {0=> 0.5, 1=> 0.5},
    'B' => {0=> 0.25, 1=> 0.75},
    };

sub forward_viterbi
 {
    my ($y, $X, $sp, $tp, $ep) = @_;
    my $T =  {};
    foreach my $state (@$X) {
        $T->{$state} = [ $sp->{$state}, [$state], $sp->{$state} ]; 
    }
    foreach my $output (@$y) {
        my $U = {};
        foreach my $next_state (@$X) {
            my $total = 0;
            my $argmax = [];
            my $valmax = 0;
            foreach my $state (@$X) {
                my ($prob, $v_path, $v_prob) = @{$T->{$state}};
                my $p = $ep->{$state}{$output} * $tp->{$state}{$next_state};
                $prob *= $p;
                $v_prob *= $p;
                $total += $prob;
                if ($v_prob > $valmax) {
                    $argmax = [ @$v_path, $next_state ];
                    $valmax = $v_prob;
                }
            }
            $U->{$next_state} = [ $total, $argmax, $valmax ];
        }
        $T = $U;
    }

    my $total = 0;
    my $argmax = [];
    my $valmax = 0;
    foreach my $state (@$X) {
        my ($prob, $v_path, $v_prob) = @{$T->{$state}};
        $total += $prob;
        if ($v_prob > $valmax) {
            $argmax = $v_path;
            $valmax = $v_prob;
        }
    }
#print "$total\n";
#print "$argmax\n";
#print "$valmax\n";

    return ($total, $argmax, $valmax);
 }

sub example(){
    return &forward_viterbi($observations,
                            $states,
                            $start_probability,
                            $transition_probability,
                            $emission_probability);
}
example();