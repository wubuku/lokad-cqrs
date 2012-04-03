#region (c) 2010-2012 Lokad - CQRS Sample for Windows Azure - New BSD License 

// Copyright (c) Lokad 2010-2012, http://www.lokad.com
// This code is released as Open Source under the terms of the New BSD Licence

#endregion

#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162
// Missing XML comment for publicly visible type or member 'Type_or_Member'
#pragma warning disable 1591


using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Antlr.Runtime;
using Antlr.Runtime.Tree;
using RewriteRuleITokenStream = Antlr.Runtime.Tree.RewriteRuleTokenStream;

namespace MessageContracts
{
    [GeneratedCode("ANTLR", "3.4")]
    [CLSCompliant(false)]
    public partial class MessageContractsParser : Parser
    {
        internal static readonly string[] tokenNames = new[]
            {
                "<invalid>", "<EOR>", "<DOWN>", "<UP>", "BlockToken", "COMMENT", "CommandToken", "DisctionaryToken",
                "ENTITY", "EntityDefinition", "EventToken", "FragmentEntry", "FragmentGroup", "FragmentReference", "ID",
                "INT", "LET", "MemberToken", "Modifier", "ModifierDefinition", "TypeToken", "USING", "WS", "'('", "')'",
                "','", "';'", "'='"
            };

        public const int EOF = -1;
        public const int T__23 = 23;
        public const int T__24 = 24;
        public const int T__25 = 25;
        public const int T__26 = 26;
        public const int T__27 = 27;
        public const int BlockToken = 4;
        public const int COMMENT = 5;
        public const int CommandToken = 6;
        public const int DisctionaryToken = 7;
        public const int ENTITY = 8;
        public const int EntityDefinition = 9;
        public const int EventToken = 10;
        public const int FragmentEntry = 11;
        public const int FragmentGroup = 12;
        public const int FragmentReference = 13;
        public const int ID = 14;
        public const int INT = 15;
        public const int LET = 16;
        public const int MemberToken = 17;
        public const int Modifier = 18;
        public const int ModifierDefinition = 19;
        public const int TypeToken = 20;
        public const int USING = 21;
        public const int WS = 22;

#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, false, false, false, false, false, false
			};
	#else
        static readonly bool[] decisionCanBacktrack = new bool[0];
#endif

        public MessageContractsParser(ITokenStream input)
            : this(input, new RecognizerSharedState()) {}

        public MessageContractsParser(ITokenStream input, RecognizerSharedState state)
            : base(input, state)
        {
            OnCreated();
        }

        ITreeAdaptor adaptor;

        public ITreeAdaptor TreeAdaptor
        {
            get { return adaptor; }

            set { this.adaptor = value; }
        }

        public override string[] TokenNames
        {
            get { return tokenNames; }
        }

        public override string GrammarFileName
        {
            get { return "/Users/abdullin/MessageContracts.g"; }
        }


        [Conditional("ANTLR_TRACE")]
        protected virtual void OnCreated() {}

        [Conditional("ANTLR_TRACE")]
        protected virtual void EnterRule(string ruleName, int ruleIndex) {}

        [Conditional("ANTLR_TRACE")]
        protected virtual void LeaveRule(string ruleName, int ruleIndex) {}

        #region Rules

        [Conditional("ANTLR_TRACE")]
        protected virtual void EnterRule_program() {}

        [Conditional("ANTLR_TRACE")]
        protected virtual void LeaveRule_program() {}

        // $ANTLR start "program"
        // /Users/abdullin/MessageContracts.g:27:1: program : ( declaration )+ ;
        [GrammarRule("program")]
        AstParserRuleReturnScope<object, IToken> program()
        {
            EnterRule_program();
            EnterRule("program", 1);
            TraceIn("program", 1);
            AstParserRuleReturnScope<object, IToken> retval = new AstParserRuleReturnScope<object, IToken>();
            retval.Start = input.LT(1);

            object root_0 = default(object);

            AstParserRuleReturnScope<object, IToken> declaration1 = default(AstParserRuleReturnScope<object, IToken>);


            try
            {
                DebugEnterRule(GrammarFileName, "program");
                DebugLocation(27, 1);
                try
                {
                    // /Users/abdullin/MessageContracts.g:28:2: ( ( declaration )+ )
                    DebugEnterAlt(1);
                    // /Users/abdullin/MessageContracts.g:28:4: ( declaration )+
                    {
                        root_0 = adaptor.Nil();

                        DebugLocation(28, 4);
                        // /Users/abdullin/MessageContracts.g:28:4: ( declaration )+
                        int cnt1 = 0;
                        try
                        {
                            DebugEnterSubRule(1);
                            while (true)
                            {
                                int alt1 = 2;
                                try
                                {
                                    DebugEnterDecision(1, decisionCanBacktrack[1]);
                                    int LA1_0 = input.LA(1);

                                    if ((LA1_0 == ENTITY || LA1_0 == ID || LA1_0 == LET || LA1_0 == USING))
                                    {
                                        alt1 = 1;
                                    }
                                }
                                finally
                                {
                                    DebugExitDecision(1);
                                }
                                switch (alt1)
                                {
                                    case 1:
                                        DebugEnterAlt(1);
                                        // /Users/abdullin/MessageContracts.g:28:4: declaration
                                        {
                                            DebugLocation(28, 4);
                                            PushFollow(Follow._declaration_in_program101);
                                            declaration1 = declaration();
                                            PopFollow();

                                            adaptor.AddChild(root_0, declaration1.Tree);
                                        }
                                        break;

                                    default:
                                        if (cnt1 >= 1)
                                            goto loop1;

                                        EarlyExitException eee1 = new EarlyExitException(1, input);
                                        DebugRecognitionException(eee1);
                                        throw eee1;
                                }
                                cnt1++;
                            }
                            loop1:
                            ;
                        }
                        finally
                        {
                            DebugExitSubRule(1);
                        }
                    }

                    retval.Stop = input.LT(-1);

                    retval.Tree = adaptor.RulePostProcessing(root_0);
                    adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
                }
                catch (RecognitionException re)
                {
                    ReportError(re);
                    Recover(input, re);
                    retval.Tree = adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);
                }
                finally
                {
                    TraceOut("program", 1);
                    LeaveRule("program", 1);
                    LeaveRule_program();
                }
                DebugLocation(29, 1);
            }
            finally
            {
                DebugExitRule(GrammarFileName, "program");
            }
            return retval;
        }

        // $ANTLR end "program"


        [Conditional("ANTLR_TRACE")]
        protected virtual void EnterRule_declaration() {}

        [Conditional("ANTLR_TRACE")]
        protected virtual void LeaveRule_declaration() {}

        // $ANTLR start "declaration"
        // /Users/abdullin/MessageContracts.g:31:1: declaration : ( modifier_declaration | frag_declaration | type_declaration | entity_declaration );
        [GrammarRule("declaration")]
        AstParserRuleReturnScope<object, IToken> declaration()
        {
            EnterRule_declaration();
            EnterRule("declaration", 2);
            TraceIn("declaration", 2);
            AstParserRuleReturnScope<object, IToken> retval = new AstParserRuleReturnScope<object, IToken>();
            retval.Start = input.LT(1);

            object root_0 = default(object);

            AstParserRuleReturnScope<object, IToken> modifier_declaration2 =
                default(AstParserRuleReturnScope<object, IToken>);
            AstParserRuleReturnScope<object, IToken> frag_declaration3 =
                default(AstParserRuleReturnScope<object, IToken>);
            AstParserRuleReturnScope<object, IToken> type_declaration4 =
                default(AstParserRuleReturnScope<object, IToken>);
            AstParserRuleReturnScope<object, IToken> entity_declaration5 =
                default(AstParserRuleReturnScope<object, IToken>);


            try
            {
                DebugEnterRule(GrammarFileName, "declaration");
                DebugLocation(31, 1);
                try
                {
                    // /Users/abdullin/MessageContracts.g:32:2: ( modifier_declaration | frag_declaration | type_declaration | entity_declaration )
                    int alt2 = 4;
                    try
                    {
                        DebugEnterDecision(2, decisionCanBacktrack[2]);
                        switch (input.LA(1))
                        {
                            case USING:
                                {
                                    alt2 = 1;
                                }
                                break;
                            case LET:
                                {
                                    alt2 = 2;
                                }
                                break;
                            case ID:
                                {
                                    alt2 = 3;
                                }
                                break;
                            case ENTITY:
                                {
                                    alt2 = 4;
                                }
                                break;
                            default:
                                {
                                    NoViableAltException nvae = new NoViableAltException("", 2, 0, input);
                                    DebugRecognitionException(nvae);
                                    throw nvae;
                                }
                        }
                    }
                    finally
                    {
                        DebugExitDecision(2);
                    }
                    switch (alt2)
                    {
                        case 1:
                            DebugEnterAlt(1);
                            // /Users/abdullin/MessageContracts.g:32:4: modifier_declaration
                            {
                                root_0 = adaptor.Nil();

                                DebugLocation(32, 4);
                                PushFollow(Follow._modifier_declaration_in_declaration114);
                                modifier_declaration2 = modifier_declaration();
                                PopFollow();

                                adaptor.AddChild(root_0, modifier_declaration2.Tree);
                            }
                            break;
                        case 2:
                            DebugEnterAlt(2);
                            // /Users/abdullin/MessageContracts.g:33:4: frag_declaration
                            {
                                root_0 = adaptor.Nil();

                                DebugLocation(33, 4);
                                PushFollow(Follow._frag_declaration_in_declaration119);
                                frag_declaration3 = frag_declaration();
                                PopFollow();

                                adaptor.AddChild(root_0, frag_declaration3.Tree);
                            }
                            break;
                        case 3:
                            DebugEnterAlt(3);
                            // /Users/abdullin/MessageContracts.g:34:4: type_declaration
                            {
                                root_0 = adaptor.Nil();

                                DebugLocation(34, 4);
                                PushFollow(Follow._type_declaration_in_declaration124);
                                type_declaration4 = type_declaration();
                                PopFollow();

                                adaptor.AddChild(root_0, type_declaration4.Tree);
                            }
                            break;
                        case 4:
                            DebugEnterAlt(4);
                            // /Users/abdullin/MessageContracts.g:35:4: entity_declaration
                            {
                                root_0 = adaptor.Nil();

                                DebugLocation(35, 4);
                                PushFollow(Follow._entity_declaration_in_declaration129);
                                entity_declaration5 = entity_declaration();
                                PopFollow();

                                adaptor.AddChild(root_0, entity_declaration5.Tree);
                            }
                            break;
                    }
                    retval.Stop = input.LT(-1);

                    retval.Tree = adaptor.RulePostProcessing(root_0);
                    adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
                }
                catch (RecognitionException re)
                {
                    ReportError(re);
                    Recover(input, re);
                    retval.Tree = adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);
                }
                finally
                {
                    TraceOut("declaration", 2);
                    LeaveRule("declaration", 2);
                    LeaveRule_declaration();
                }
                DebugLocation(36, 1);
            }
            finally
            {
                DebugExitRule(GrammarFileName, "declaration");
            }
            return retval;
        }

        // $ANTLR end "declaration"


        [Conditional("ANTLR_TRACE")]
        protected virtual void EnterRule_frag_declaration() {}

        [Conditional("ANTLR_TRACE")]
        protected virtual void LeaveRule_frag_declaration() {}

        // $ANTLR start "frag_declaration"
        // /Users/abdullin/MessageContracts.g:38:1: frag_declaration : LET ID '=' ID ID ';' -> ^( FragmentEntry ID ID ID ) ;
        [GrammarRule("frag_declaration")]
        AstParserRuleReturnScope<object, IToken> frag_declaration()
        {
            EnterRule_frag_declaration();
            EnterRule("frag_declaration", 3);
            TraceIn("frag_declaration", 3);
            AstParserRuleReturnScope<object, IToken> retval = new AstParserRuleReturnScope<object, IToken>();
            retval.Start = input.LT(1);

            object root_0 = default(object);

            IToken LET6 = default(IToken);
            IToken ID7 = default(IToken);
            IToken char_literal8 = default(IToken);
            IToken ID9 = default(IToken);
            IToken ID10 = default(IToken);
            IToken char_literal11 = default(IToken);

            object LET6_tree = default(object);
            object ID7_tree = default(object);
            object char_literal8_tree = default(object);
            object ID9_tree = default(object);
            object ID10_tree = default(object);
            object char_literal11_tree = default(object);
            RewriteRuleITokenStream stream_ID = new RewriteRuleITokenStream(adaptor, "token ID");
            RewriteRuleITokenStream stream_LET = new RewriteRuleITokenStream(adaptor, "token LET");
            RewriteRuleITokenStream stream_26 = new RewriteRuleITokenStream(adaptor, "token 26");
            RewriteRuleITokenStream stream_27 = new RewriteRuleITokenStream(adaptor, "token 27");

            try
            {
                DebugEnterRule(GrammarFileName, "frag_declaration");
                DebugLocation(38, 52);
                try
                {
                    // /Users/abdullin/MessageContracts.g:39:2: ( LET ID '=' ID ID ';' -> ^( FragmentEntry ID ID ID ) )
                    DebugEnterAlt(1);
                    // /Users/abdullin/MessageContracts.g:39:4: LET ID '=' ID ID ';'
                    {
                        DebugLocation(39, 4);
                        LET6 = (IToken) Match(input, LET, Follow._LET_in_frag_declaration141);
                        stream_LET.Add(LET6);

                        DebugLocation(39, 8);
                        ID7 = (IToken) Match(input, ID, Follow._ID_in_frag_declaration143);
                        stream_ID.Add(ID7);

                        DebugLocation(39, 11);
                        char_literal8 = (IToken) Match(input, 27, Follow._27_in_frag_declaration145);
                        stream_27.Add(char_literal8);

                        DebugLocation(39, 15);
                        ID9 = (IToken) Match(input, ID, Follow._ID_in_frag_declaration147);
                        stream_ID.Add(ID9);

                        DebugLocation(39, 18);
                        ID10 = (IToken) Match(input, ID, Follow._ID_in_frag_declaration149);
                        stream_ID.Add(ID10);

                        DebugLocation(39, 21);
                        char_literal11 = (IToken) Match(input, 26, Follow._26_in_frag_declaration151);
                        stream_26.Add(char_literal11);


                        {
                            // AST REWRITE
                            // elements: ID, ID, ID
                            // token labels: 
                            // rule labels: retval
                            // token list labels: 
                            // rule list labels: 
                            // wildcard labels: 
                            retval.Tree = root_0;
                            RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval",
                                retval != null ? retval.Tree : null);

                            root_0 = adaptor.Nil();
                            // 39:25: -> ^( FragmentEntry ID ID ID )
                            {
                                DebugLocation(39, 28);
                                // /Users/abdullin/MessageContracts.g:39:28: ^( FragmentEntry ID ID ID )
                                {
                                    object root_1 = adaptor.Nil();
                                    DebugLocation(39, 30);
                                    root_1 = adaptor.BecomeRoot(adaptor.Create(FragmentEntry, "FragmentEntry"), root_1);

                                    DebugLocation(39, 44);
                                    adaptor.AddChild(root_1, stream_ID.NextNode());
                                    DebugLocation(39, 47);
                                    adaptor.AddChild(root_1, stream_ID.NextNode());
                                    DebugLocation(39, 50);
                                    adaptor.AddChild(root_1, stream_ID.NextNode());

                                    adaptor.AddChild(root_0, root_1);
                                }
                            }

                            retval.Tree = root_0;
                        }
                    }

                    retval.Stop = input.LT(-1);

                    retval.Tree = adaptor.RulePostProcessing(root_0);
                    adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
                }
                catch (RecognitionException re)
                {
                    ReportError(re);
                    Recover(input, re);
                    retval.Tree = adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);
                }
                finally
                {
                    TraceOut("frag_declaration", 3);
                    LeaveRule("frag_declaration", 3);
                    LeaveRule_frag_declaration();
                }
                DebugLocation(39, 52);
            }
            finally
            {
                DebugExitRule(GrammarFileName, "frag_declaration");
            }
            return retval;
        }

        // $ANTLR end "frag_declaration"


        [Conditional("ANTLR_TRACE")]
        protected virtual void EnterRule_modifier_declaration() {}

        [Conditional("ANTLR_TRACE")]
        protected virtual void LeaveRule_modifier_declaration() {}

        // $ANTLR start "modifier_declaration"
        // /Users/abdullin/MessageContracts.g:41:1: modifier_declaration : USING Modifier '=' ID ( ',' ID )* ';' -> ^( ModifierDefinition Modifier ( ID )* ) ;
        [GrammarRule("modifier_declaration")]
        AstParserRuleReturnScope<object, IToken> modifier_declaration()
        {
            EnterRule_modifier_declaration();
            EnterRule("modifier_declaration", 4);
            TraceIn("modifier_declaration", 4);
            AstParserRuleReturnScope<object, IToken> retval = new AstParserRuleReturnScope<object, IToken>();
            retval.Start = input.LT(1);

            object root_0 = default(object);

            IToken USING12 = default(IToken);
            IToken Modifier13 = default(IToken);
            IToken char_literal14 = default(IToken);
            IToken ID15 = default(IToken);
            IToken char_literal16 = default(IToken);
            IToken ID17 = default(IToken);
            IToken char_literal18 = default(IToken);

            object USING12_tree = default(object);
            object Modifier13_tree = default(object);
            object char_literal14_tree = default(object);
            object ID15_tree = default(object);
            object char_literal16_tree = default(object);
            object ID17_tree = default(object);
            object char_literal18_tree = default(object);
            RewriteRuleITokenStream stream_USING = new RewriteRuleITokenStream(adaptor, "token USING");
            RewriteRuleITokenStream stream_ID = new RewriteRuleITokenStream(adaptor, "token ID");
            RewriteRuleITokenStream stream_Modifier = new RewriteRuleITokenStream(adaptor, "token Modifier");
            RewriteRuleITokenStream stream_25 = new RewriteRuleITokenStream(adaptor, "token 25");
            RewriteRuleITokenStream stream_26 = new RewriteRuleITokenStream(adaptor, "token 26");
            RewriteRuleITokenStream stream_27 = new RewriteRuleITokenStream(adaptor, "token 27");

            try
            {
                DebugEnterRule(GrammarFileName, "modifier_declaration");
                DebugLocation(41, 76);
                try
                {
                    // /Users/abdullin/MessageContracts.g:42:2: ( USING Modifier '=' ID ( ',' ID )* ';' -> ^( ModifierDefinition Modifier ( ID )* ) )
                    DebugEnterAlt(1);
                    // /Users/abdullin/MessageContracts.g:42:4: USING Modifier '=' ID ( ',' ID )* ';'
                    {
                        DebugLocation(42, 4);
                        USING12 = (IToken) Match(input, USING, Follow._USING_in_modifier_declaration178);
                        stream_USING.Add(USING12);

                        DebugLocation(42, 10);
                        Modifier13 = (IToken) Match(input, Modifier, Follow._Modifier_in_modifier_declaration180);
                        stream_Modifier.Add(Modifier13);

                        DebugLocation(42, 19);
                        char_literal14 = (IToken) Match(input, 27, Follow._27_in_modifier_declaration182);
                        stream_27.Add(char_literal14);

                        DebugLocation(42, 23);
                        ID15 = (IToken) Match(input, ID, Follow._ID_in_modifier_declaration184);
                        stream_ID.Add(ID15);

                        DebugLocation(42, 26);
                        // /Users/abdullin/MessageContracts.g:42:26: ( ',' ID )*
                        try
                        {
                            DebugEnterSubRule(3);
                            while (true)
                            {
                                int alt3 = 2;
                                try
                                {
                                    DebugEnterDecision(3, decisionCanBacktrack[3]);
                                    int LA3_0 = input.LA(1);

                                    if ((LA3_0 == 25))
                                    {
                                        alt3 = 1;
                                    }
                                }
                                finally
                                {
                                    DebugExitDecision(3);
                                }
                                switch (alt3)
                                {
                                    case 1:
                                        DebugEnterAlt(1);
                                        // /Users/abdullin/MessageContracts.g:42:27: ',' ID
                                        {
                                            DebugLocation(42, 27);
                                            char_literal16 =
                                                (IToken) Match(input, 25, Follow._25_in_modifier_declaration187);
                                            stream_25.Add(char_literal16);

                                            DebugLocation(42, 31);
                                            ID17 = (IToken) Match(input, ID, Follow._ID_in_modifier_declaration189);
                                            stream_ID.Add(ID17);
                                        }
                                        break;

                                    default:
                                        goto loop3;
                                }
                            }

                            loop3:
                            ;
                        }
                        finally
                        {
                            DebugExitSubRule(3);
                        }

                        DebugLocation(42, 36);
                        char_literal18 = (IToken) Match(input, 26, Follow._26_in_modifier_declaration193);
                        stream_26.Add(char_literal18);


                        {
                            // AST REWRITE
                            // elements: ID, Modifier
                            // token labels: 
                            // rule labels: retval
                            // token list labels: 
                            // rule list labels: 
                            // wildcard labels: 
                            retval.Tree = root_0;
                            RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval",
                                retval != null ? retval.Tree : null);

                            root_0 = adaptor.Nil();
                            // 42:40: -> ^( ModifierDefinition Modifier ( ID )* )
                            {
                                DebugLocation(42, 43);
                                // /Users/abdullin/MessageContracts.g:42:43: ^( ModifierDefinition Modifier ( ID )* )
                                {
                                    object root_1 = adaptor.Nil();
                                    DebugLocation(42, 45);
                                    root_1 = adaptor.BecomeRoot(
                                        adaptor.Create(ModifierDefinition, "ModifierDefinition"), root_1);

                                    DebugLocation(42, 64);
                                    adaptor.AddChild(root_1, stream_Modifier.NextNode());
                                    DebugLocation(42, 73);
                                    // /Users/abdullin/MessageContracts.g:42:73: ( ID )*
                                    while (stream_ID.HasNext)
                                    {
                                        DebugLocation(42, 73);
                                        adaptor.AddChild(root_1, stream_ID.NextNode());
                                    }
                                    stream_ID.Reset();

                                    adaptor.AddChild(root_0, root_1);
                                }
                            }

                            retval.Tree = root_0;
                        }
                    }

                    retval.Stop = input.LT(-1);

                    retval.Tree = adaptor.RulePostProcessing(root_0);
                    adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
                }
                catch (RecognitionException re)
                {
                    ReportError(re);
                    Recover(input, re);
                    retval.Tree = adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);
                }
                finally
                {
                    TraceOut("modifier_declaration", 4);
                    LeaveRule("modifier_declaration", 4);
                    LeaveRule_modifier_declaration();
                }
                DebugLocation(42, 76);
            }
            finally
            {
                DebugExitRule(GrammarFileName, "modifier_declaration");
            }
            return retval;
        }

        // $ANTLR end "modifier_declaration"


        [Conditional("ANTLR_TRACE")]
        protected virtual void EnterRule_entity_declaration() {}

        [Conditional("ANTLR_TRACE")]
        protected virtual void LeaveRule_entity_declaration() {}

        // $ANTLR start "entity_declaration"
        // /Users/abdullin/MessageContracts.g:45:1: entity_declaration : ENTITY ID block ';' -> ^( EntityDefinition ID block ) ;
        [GrammarRule("entity_declaration")]
        AstParserRuleReturnScope<object, IToken> entity_declaration()
        {
            EnterRule_entity_declaration();
            EnterRule("entity_declaration", 5);
            TraceIn("entity_declaration", 5);
            AstParserRuleReturnScope<object, IToken> retval = new AstParserRuleReturnScope<object, IToken>();
            retval.Start = input.LT(1);

            object root_0 = default(object);

            IToken ENTITY19 = default(IToken);
            IToken ID20 = default(IToken);
            IToken char_literal22 = default(IToken);
            AstParserRuleReturnScope<object, IToken> block21 = default(AstParserRuleReturnScope<object, IToken>);

            object ENTITY19_tree = default(object);
            object ID20_tree = default(object);
            object char_literal22_tree = default(object);
            RewriteRuleITokenStream stream_ID = new RewriteRuleITokenStream(adaptor, "token ID");
            RewriteRuleITokenStream stream_26 = new RewriteRuleITokenStream(adaptor, "token 26");
            RewriteRuleITokenStream stream_ENTITY = new RewriteRuleITokenStream(adaptor, "token ENTITY");
            RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor, "rule block");
            try
            {
                DebugEnterRule(GrammarFileName, "entity_declaration");
                DebugLocation(45, 54);
                try
                {
                    // /Users/abdullin/MessageContracts.g:46:2: ( ENTITY ID block ';' -> ^( EntityDefinition ID block ) )
                    DebugEnterAlt(1);
                    // /Users/abdullin/MessageContracts.g:46:4: ENTITY ID block ';'
                    {
                        DebugLocation(46, 4);
                        ENTITY19 = (IToken) Match(input, ENTITY, Follow._ENTITY_in_entity_declaration220);
                        stream_ENTITY.Add(ENTITY19);

                        DebugLocation(46, 11);
                        ID20 = (IToken) Match(input, ID, Follow._ID_in_entity_declaration222);
                        stream_ID.Add(ID20);

                        DebugLocation(46, 14);
                        PushFollow(Follow._block_in_entity_declaration224);
                        block21 = block();
                        PopFollow();

                        stream_block.Add(block21.Tree);
                        DebugLocation(46, 20);
                        char_literal22 = (IToken) Match(input, 26, Follow._26_in_entity_declaration226);
                        stream_26.Add(char_literal22);


                        {
                            // AST REWRITE
                            // elements: block, ID
                            // token labels: 
                            // rule labels: retval
                            // token list labels: 
                            // rule list labels: 
                            // wildcard labels: 
                            retval.Tree = root_0;
                            RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval",
                                retval != null ? retval.Tree : null);

                            root_0 = adaptor.Nil();
                            // 46:24: -> ^( EntityDefinition ID block )
                            {
                                DebugLocation(46, 27);
                                // /Users/abdullin/MessageContracts.g:46:27: ^( EntityDefinition ID block )
                                {
                                    object root_1 = adaptor.Nil();
                                    DebugLocation(46, 29);
                                    root_1 = adaptor.BecomeRoot(adaptor.Create(EntityDefinition, "EntityDefinition"),
                                        root_1);

                                    DebugLocation(46, 46);
                                    adaptor.AddChild(root_1, stream_ID.NextNode());
                                    DebugLocation(46, 49);
                                    adaptor.AddChild(root_1, stream_block.NextTree());

                                    adaptor.AddChild(root_0, root_1);
                                }
                            }

                            retval.Tree = root_0;
                        }
                    }

                    retval.Stop = input.LT(-1);

                    retval.Tree = adaptor.RulePostProcessing(root_0);
                    adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
                }
                catch (RecognitionException re)
                {
                    ReportError(re);
                    Recover(input, re);
                    retval.Tree = adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);
                }
                finally
                {
                    TraceOut("entity_declaration", 5);
                    LeaveRule("entity_declaration", 5);
                    LeaveRule_entity_declaration();
                }
                DebugLocation(46, 54);
            }
            finally
            {
                DebugExitRule(GrammarFileName, "entity_declaration");
            }
            return retval;
        }

        // $ANTLR end "entity_declaration"


        [Conditional("ANTLR_TRACE")]
        protected virtual void EnterRule_type_declaration() {}

        [Conditional("ANTLR_TRACE")]
        protected virtual void LeaveRule_type_declaration() {}

        // $ANTLR start "type_declaration"
        // /Users/abdullin/MessageContracts.g:48:1: type_declaration : ID ( Modifier )* block -> ^( TypeToken ID block ( Modifier )* ) ;
        [GrammarRule("type_declaration")]
        AstParserRuleReturnScope<object, IToken> type_declaration()
        {
            EnterRule_type_declaration();
            EnterRule("type_declaration", 6);
            TraceIn("type_declaration", 6);
            AstParserRuleReturnScope<object, IToken> retval = new AstParserRuleReturnScope<object, IToken>();
            retval.Start = input.LT(1);

            object root_0 = default(object);

            IToken ID23 = default(IToken);
            IToken Modifier24 = default(IToken);
            AstParserRuleReturnScope<object, IToken> block25 = default(AstParserRuleReturnScope<object, IToken>);

            object ID23_tree = default(object);
            object Modifier24_tree = default(object);
            RewriteRuleITokenStream stream_ID = new RewriteRuleITokenStream(adaptor, "token ID");
            RewriteRuleITokenStream stream_Modifier = new RewriteRuleITokenStream(adaptor, "token Modifier");
            RewriteRuleSubtreeStream stream_block = new RewriteRuleSubtreeStream(adaptor, "rule block");
            try
            {
                DebugEnterRule(GrammarFileName, "type_declaration");
                DebugLocation(48, 56);
                try
                {
                    // /Users/abdullin/MessageContracts.g:49:2: ( ID ( Modifier )* block -> ^( TypeToken ID block ( Modifier )* ) )
                    DebugEnterAlt(1);
                    // /Users/abdullin/MessageContracts.g:49:4: ID ( Modifier )* block
                    {
                        DebugLocation(49, 4);
                        ID23 = (IToken) Match(input, ID, Follow._ID_in_type_declaration246);
                        stream_ID.Add(ID23);

                        DebugLocation(49, 7);
                        // /Users/abdullin/MessageContracts.g:49:7: ( Modifier )*
                        try
                        {
                            DebugEnterSubRule(4);
                            while (true)
                            {
                                int alt4 = 2;
                                try
                                {
                                    DebugEnterDecision(4, decisionCanBacktrack[4]);
                                    int LA4_0 = input.LA(1);

                                    if ((LA4_0 == Modifier))
                                    {
                                        alt4 = 1;
                                    }
                                }
                                finally
                                {
                                    DebugExitDecision(4);
                                }
                                switch (alt4)
                                {
                                    case 1:
                                        DebugEnterAlt(1);
                                        // /Users/abdullin/MessageContracts.g:49:7: Modifier
                                        {
                                            DebugLocation(49, 7);
                                            Modifier24 =
                                                (IToken) Match(input, Modifier, Follow._Modifier_in_type_declaration248);
                                            stream_Modifier.Add(Modifier24);
                                        }
                                        break;

                                    default:
                                        goto loop4;
                                }
                            }

                            loop4:
                            ;
                        }
                        finally
                        {
                            DebugExitSubRule(4);
                        }

                        DebugLocation(49, 17);
                        PushFollow(Follow._block_in_type_declaration251);
                        block25 = block();
                        PopFollow();

                        stream_block.Add(block25.Tree);


                        {
                            // AST REWRITE
                            // elements: Modifier, block, ID
                            // token labels: 
                            // rule labels: retval
                            // token list labels: 
                            // rule list labels: 
                            // wildcard labels: 
                            retval.Tree = root_0;
                            RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval",
                                retval != null ? retval.Tree : null);

                            root_0 = adaptor.Nil();
                            // 49:23: -> ^( TypeToken ID block ( Modifier )* )
                            {
                                DebugLocation(49, 26);
                                // /Users/abdullin/MessageContracts.g:49:26: ^( TypeToken ID block ( Modifier )* )
                                {
                                    object root_1 = adaptor.Nil();
                                    DebugLocation(49, 28);
                                    root_1 = adaptor.BecomeRoot(adaptor.Create(TypeToken, "TypeToken"), root_1);

                                    DebugLocation(49, 38);
                                    adaptor.AddChild(root_1, stream_ID.NextNode());
                                    DebugLocation(49, 41);
                                    adaptor.AddChild(root_1, stream_block.NextTree());
                                    DebugLocation(49, 47);
                                    // /Users/abdullin/MessageContracts.g:49:47: ( Modifier )*
                                    while (stream_Modifier.HasNext)
                                    {
                                        DebugLocation(49, 47);
                                        adaptor.AddChild(root_1, stream_Modifier.NextNode());
                                    }
                                    stream_Modifier.Reset();

                                    adaptor.AddChild(root_0, root_1);
                                }
                            }

                            retval.Tree = root_0;
                        }
                    }

                    retval.Stop = input.LT(-1);

                    retval.Tree = adaptor.RulePostProcessing(root_0);
                    adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
                }
                catch (RecognitionException re)
                {
                    ReportError(re);
                    Recover(input, re);
                    retval.Tree = adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);
                }
                finally
                {
                    TraceOut("type_declaration", 6);
                    LeaveRule("type_declaration", 6);
                    LeaveRule_type_declaration();
                }
                DebugLocation(49, 56);
            }
            finally
            {
                DebugExitRule(GrammarFileName, "type_declaration");
            }
            return retval;
        }

        // $ANTLR end "type_declaration"


        [Conditional("ANTLR_TRACE")]
        protected virtual void EnterRule_member() {}

        [Conditional("ANTLR_TRACE")]
        protected virtual void LeaveRule_member() {}

        // $ANTLR start "member"
        // /Users/abdullin/MessageContracts.g:51:1: member : ( ID ID -> ^( MemberToken ID ID ) | ID -> ^( FragmentReference ID ) );
        [GrammarRule("member")]
        AstParserRuleReturnScope<object, IToken> member()
        {
            EnterRule_member();
            EnterRule("member", 7);
            TraceIn("member", 7);
            AstParserRuleReturnScope<object, IToken> retval = new AstParserRuleReturnScope<object, IToken>();
            retval.Start = input.LT(1);

            object root_0 = default(object);

            IToken ID26 = default(IToken);
            IToken ID27 = default(IToken);
            IToken ID28 = default(IToken);

            object ID26_tree = default(object);
            object ID27_tree = default(object);
            object ID28_tree = default(object);
            RewriteRuleITokenStream stream_ID = new RewriteRuleITokenStream(adaptor, "token ID");

            try
            {
                DebugEnterRule(GrammarFileName, "member");
                DebugLocation(51, 1);
                try
                {
                    // /Users/abdullin/MessageContracts.g:52:2: ( ID ID -> ^( MemberToken ID ID ) | ID -> ^( FragmentReference ID ) )
                    int alt5 = 2;
                    try
                    {
                        DebugEnterDecision(5, decisionCanBacktrack[5]);
                        int LA5_0 = input.LA(1);

                        if ((LA5_0 == ID))
                        {
                            int LA5_1 = input.LA(2);

                            if ((LA5_1 == ID))
                            {
                                alt5 = 1;
                            }
                            else if (((LA5_1 >= 24 && LA5_1 <= 25)))
                            {
                                alt5 = 2;
                            }
                            else
                            {
                                NoViableAltException nvae = new NoViableAltException("", 5, 1, input);
                                DebugRecognitionException(nvae);
                                throw nvae;
                            }
                        }
                        else
                        {
                            NoViableAltException nvae = new NoViableAltException("", 5, 0, input);
                            DebugRecognitionException(nvae);
                            throw nvae;
                        }
                    }
                    finally
                    {
                        DebugExitDecision(5);
                    }
                    switch (alt5)
                    {
                        case 1:
                            DebugEnterAlt(1);
                            // /Users/abdullin/MessageContracts.g:52:4: ID ID
                            {
                                DebugLocation(52, 4);
                                ID26 = (IToken) Match(input, ID, Follow._ID_in_member276);
                                stream_ID.Add(ID26);

                                DebugLocation(52, 7);
                                ID27 = (IToken) Match(input, ID, Follow._ID_in_member278);
                                stream_ID.Add(ID27);


                                {
                                    // AST REWRITE
                                    // elements: ID, ID
                                    // token labels: 
                                    // rule labels: retval
                                    // token list labels: 
                                    // rule list labels: 
                                    // wildcard labels: 
                                    retval.Tree = root_0;
                                    RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor,
                                        "rule retval", retval != null ? retval.Tree : null);

                                    root_0 = adaptor.Nil();
                                    // 52:10: -> ^( MemberToken ID ID )
                                    {
                                        DebugLocation(52, 13);
                                        // /Users/abdullin/MessageContracts.g:52:13: ^( MemberToken ID ID )
                                        {
                                            object root_1 = adaptor.Nil();
                                            DebugLocation(52, 15);
                                            root_1 = adaptor.BecomeRoot(adaptor.Create(MemberToken, "MemberToken"),
                                                root_1);

                                            DebugLocation(52, 27);
                                            adaptor.AddChild(root_1, stream_ID.NextNode());
                                            DebugLocation(52, 30);
                                            adaptor.AddChild(root_1, stream_ID.NextNode());

                                            adaptor.AddChild(root_0, root_1);
                                        }
                                    }

                                    retval.Tree = root_0;
                                }
                            }
                            break;
                        case 2:
                            DebugEnterAlt(2);
                            // /Users/abdullin/MessageContracts.g:53:4: ID
                            {
                                DebugLocation(53, 4);
                                ID28 = (IToken) Match(input, ID, Follow._ID_in_member293);
                                stream_ID.Add(ID28);


                                {
                                    // AST REWRITE
                                    // elements: ID
                                    // token labels: 
                                    // rule labels: retval
                                    // token list labels: 
                                    // rule list labels: 
                                    // wildcard labels: 
                                    retval.Tree = root_0;
                                    RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor,
                                        "rule retval", retval != null ? retval.Tree : null);

                                    root_0 = adaptor.Nil();
                                    // 53:7: -> ^( FragmentReference ID )
                                    {
                                        DebugLocation(53, 10);
                                        // /Users/abdullin/MessageContracts.g:53:10: ^( FragmentReference ID )
                                        {
                                            object root_1 = adaptor.Nil();
                                            DebugLocation(53, 12);
                                            root_1 =
                                                adaptor.BecomeRoot(
                                                    adaptor.Create(FragmentReference, "FragmentReference"), root_1);

                                            DebugLocation(53, 30);
                                            adaptor.AddChild(root_1, stream_ID.NextNode());

                                            adaptor.AddChild(root_0, root_1);
                                        }
                                    }

                                    retval.Tree = root_0;
                                }
                            }
                            break;
                    }
                    retval.Stop = input.LT(-1);

                    retval.Tree = adaptor.RulePostProcessing(root_0);
                    adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
                }
                catch (RecognitionException re)
                {
                    ReportError(re);
                    Recover(input, re);
                    retval.Tree = adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);
                }
                finally
                {
                    TraceOut("member", 7);
                    LeaveRule("member", 7);
                    LeaveRule_member();
                }
                DebugLocation(54, 1);
            }
            finally
            {
                DebugExitRule(GrammarFileName, "member");
            }
            return retval;
        }

        // $ANTLR end "member"


        [Conditional("ANTLR_TRACE")]
        protected virtual void EnterRule_block() {}

        [Conditional("ANTLR_TRACE")]
        protected virtual void LeaveRule_block() {}

        // $ANTLR start "block"
        // /Users/abdullin/MessageContracts.g:57:1: block : lc= '(' ( member ( ',' member )* )? ')' -> ^( BlockToken[$lc,\"Block\"] ( member )* ) ;
        [GrammarRule("block")]
        AstParserRuleReturnScope<object, IToken> block()
        {
            EnterRule_block();
            EnterRule("block", 8);
            TraceIn("block", 8);
            AstParserRuleReturnScope<object, IToken> retval = new AstParserRuleReturnScope<object, IToken>();
            retval.Start = input.LT(1);

            object root_0 = default(object);

            IToken lc = default(IToken);
            IToken char_literal30 = default(IToken);
            IToken char_literal32 = default(IToken);
            AstParserRuleReturnScope<object, IToken> member29 = default(AstParserRuleReturnScope<object, IToken>);
            AstParserRuleReturnScope<object, IToken> member31 = default(AstParserRuleReturnScope<object, IToken>);

            object lc_tree = default(object);
            object char_literal30_tree = default(object);
            object char_literal32_tree = default(object);
            RewriteRuleITokenStream stream_23 = new RewriteRuleITokenStream(adaptor, "token 23");
            RewriteRuleITokenStream stream_24 = new RewriteRuleITokenStream(adaptor, "token 24");
            RewriteRuleITokenStream stream_25 = new RewriteRuleITokenStream(adaptor, "token 25");
            RewriteRuleSubtreeStream stream_member = new RewriteRuleSubtreeStream(adaptor, "rule member");
            try
            {
                DebugEnterRule(GrammarFileName, "block");
                DebugLocation(57, 4);
                try
                {
                    // /Users/abdullin/MessageContracts.g:58:5: (lc= '(' ( member ( ',' member )* )? ')' -> ^( BlockToken[$lc,\"Block\"] ( member )* ) )
                    DebugEnterAlt(1);
                    // /Users/abdullin/MessageContracts.g:58:9: lc= '(' ( member ( ',' member )* )? ')'
                    {
                        DebugLocation(58, 11);
                        lc = (IToken) Match(input, 23, Follow._23_in_block321);
                        stream_23.Add(lc);

                        DebugLocation(59, 13);
                        // /Users/abdullin/MessageContracts.g:59:13: ( member ( ',' member )* )?
                        int alt7 = 2;
                        try
                        {
                            DebugEnterSubRule(7);
                            try
                            {
                                DebugEnterDecision(7, decisionCanBacktrack[7]);
                                int LA7_0 = input.LA(1);

                                if ((LA7_0 == ID))
                                {
                                    alt7 = 1;
                                }
                            }
                            finally
                            {
                                DebugExitDecision(7);
                            }
                            switch (alt7)
                            {
                                case 1:
                                    DebugEnterAlt(1);
                                    // /Users/abdullin/MessageContracts.g:59:14: member ( ',' member )*
                                    {
                                        DebugLocation(59, 14);
                                        PushFollow(Follow._member_in_block336);
                                        member29 = member();
                                        PopFollow();

                                        stream_member.Add(member29.Tree);
                                        DebugLocation(59, 21);
                                        // /Users/abdullin/MessageContracts.g:59:21: ( ',' member )*
                                        try
                                        {
                                            DebugEnterSubRule(6);
                                            while (true)
                                            {
                                                int alt6 = 2;
                                                try
                                                {
                                                    DebugEnterDecision(6, decisionCanBacktrack[6]);
                                                    int LA6_0 = input.LA(1);

                                                    if ((LA6_0 == 25))
                                                    {
                                                        alt6 = 1;
                                                    }
                                                }
                                                finally
                                                {
                                                    DebugExitDecision(6);
                                                }
                                                switch (alt6)
                                                {
                                                    case 1:
                                                        DebugEnterAlt(1);
                                                        // /Users/abdullin/MessageContracts.g:59:22: ',' member
                                                        {
                                                            DebugLocation(59, 22);
                                                            char_literal30 =
                                                                (IToken) Match(input, 25, Follow._25_in_block339);
                                                            stream_25.Add(char_literal30);

                                                            DebugLocation(59, 26);
                                                            PushFollow(Follow._member_in_block341);
                                                            member31 = member();
                                                            PopFollow();

                                                            stream_member.Add(member31.Tree);
                                                        }
                                                        break;

                                                    default:
                                                        goto loop6;
                                                }
                                            }

                                            loop6:
                                            ;
                                        }
                                        finally
                                        {
                                            DebugExitSubRule(6);
                                        }
                                    }
                                    break;
                            }
                        }
                        finally
                        {
                            DebugExitSubRule(7);
                        }

                        DebugLocation(60, 9);
                        char_literal32 = (IToken) Match(input, 24, Follow._24_in_block355);
                        stream_24.Add(char_literal32);


                        {
                            // AST REWRITE
                            // elements: member
                            // token labels: 
                            // rule labels: retval
                            // token list labels: 
                            // rule list labels: 
                            // wildcard labels: 
                            retval.Tree = root_0;
                            RewriteRuleSubtreeStream stream_retval = new RewriteRuleSubtreeStream(adaptor, "rule retval",
                                retval != null ? retval.Tree : null);

                            root_0 = adaptor.Nil();
                            // 61:9: -> ^( BlockToken[$lc,\"Block\"] ( member )* )
                            {
                                DebugLocation(61, 12);
                                // /Users/abdullin/MessageContracts.g:61:12: ^( BlockToken[$lc,\"Block\"] ( member )* )
                                {
                                    object root_1 = adaptor.Nil();
                                    DebugLocation(61, 14);
                                    root_1 = adaptor.BecomeRoot(adaptor.Create(BlockToken, lc, "Block"), root_1);

                                    DebugLocation(61, 38);
                                    // /Users/abdullin/MessageContracts.g:61:38: ( member )*
                                    while (stream_member.HasNext)
                                    {
                                        DebugLocation(61, 38);
                                        adaptor.AddChild(root_1, stream_member.NextTree());
                                    }
                                    stream_member.Reset();

                                    adaptor.AddChild(root_0, root_1);
                                }
                            }

                            retval.Tree = root_0;
                        }
                    }

                    retval.Stop = input.LT(-1);

                    retval.Tree = adaptor.RulePostProcessing(root_0);
                    adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
                }
                catch (RecognitionException re)
                {
                    ReportError(re);
                    Recover(input, re);
                    retval.Tree = adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);
                }
                finally
                {
                    TraceOut("block", 8);
                    LeaveRule("block", 8);
                    LeaveRule_block();
                }
                DebugLocation(62, 4);
            }
            finally
            {
                DebugExitRule(GrammarFileName, "block");
            }
            return retval;
        }

        // $ANTLR end "block"

        #endregion Rules

        #region Follow sets

        static class Follow
        {
            public static readonly BitSet _declaration_in_program101 = new BitSet(new[] {0x214102UL});
            public static readonly BitSet _modifier_declaration_in_declaration114 = new BitSet(new[] {0x2UL});
            public static readonly BitSet _frag_declaration_in_declaration119 = new BitSet(new[] {0x2UL});
            public static readonly BitSet _type_declaration_in_declaration124 = new BitSet(new[] {0x2UL});
            public static readonly BitSet _entity_declaration_in_declaration129 = new BitSet(new[] {0x2UL});
            public static readonly BitSet _LET_in_frag_declaration141 = new BitSet(new[] {0x4000UL});
            public static readonly BitSet _ID_in_frag_declaration143 = new BitSet(new[] {0x8000000UL});
            public static readonly BitSet _27_in_frag_declaration145 = new BitSet(new[] {0x4000UL});
            public static readonly BitSet _ID_in_frag_declaration147 = new BitSet(new[] {0x4000UL});
            public static readonly BitSet _ID_in_frag_declaration149 = new BitSet(new[] {0x4000000UL});
            public static readonly BitSet _26_in_frag_declaration151 = new BitSet(new[] {0x2UL});
            public static readonly BitSet _USING_in_modifier_declaration178 = new BitSet(new[] {0x40000UL});
            public static readonly BitSet _Modifier_in_modifier_declaration180 = new BitSet(new[] {0x8000000UL});
            public static readonly BitSet _27_in_modifier_declaration182 = new BitSet(new[] {0x4000UL});
            public static readonly BitSet _ID_in_modifier_declaration184 = new BitSet(new[] {0x6000000UL});
            public static readonly BitSet _25_in_modifier_declaration187 = new BitSet(new[] {0x4000UL});
            public static readonly BitSet _ID_in_modifier_declaration189 = new BitSet(new[] {0x6000000UL});
            public static readonly BitSet _26_in_modifier_declaration193 = new BitSet(new[] {0x2UL});
            public static readonly BitSet _ENTITY_in_entity_declaration220 = new BitSet(new[] {0x4000UL});
            public static readonly BitSet _ID_in_entity_declaration222 = new BitSet(new[] {0x800000UL});
            public static readonly BitSet _block_in_entity_declaration224 = new BitSet(new[] {0x4000000UL});
            public static readonly BitSet _26_in_entity_declaration226 = new BitSet(new[] {0x2UL});
            public static readonly BitSet _ID_in_type_declaration246 = new BitSet(new[] {0x840000UL});
            public static readonly BitSet _Modifier_in_type_declaration248 = new BitSet(new[] {0x840000UL});
            public static readonly BitSet _block_in_type_declaration251 = new BitSet(new[] {0x2UL});
            public static readonly BitSet _ID_in_member276 = new BitSet(new[] {0x4000UL});
            public static readonly BitSet _ID_in_member278 = new BitSet(new[] {0x2UL});
            public static readonly BitSet _ID_in_member293 = new BitSet(new[] {0x2UL});
            public static readonly BitSet _23_in_block321 = new BitSet(new[] {0x1004000UL});
            public static readonly BitSet _member_in_block336 = new BitSet(new[] {0x3000000UL});
            public static readonly BitSet _25_in_block339 = new BitSet(new[] {0x4000UL});
            public static readonly BitSet _member_in_block341 = new BitSet(new[] {0x3000000UL});
            public static readonly BitSet _24_in_block355 = new BitSet(new[] {0x2UL});
        }

        #endregion Follow sets
    }
}

// namespace  MessageContracts 